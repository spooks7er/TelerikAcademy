namespace ProcessingJSON.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.IO;
    using System.Xml;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            string rssVideoFeed = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string xmlFilePath = "../../rssVideos.xml";

            var dataJson = RssToJson(rssVideoFeed, xmlFilePath);

            var jObj = JObject.Parse(dataJson);

            var videosJson = jObj["feed"]["entry"];
            PrintVideoTitles(videosJson);

            List<Video> videos = new List<Video>();

            foreach (var video in videosJson)
            {
                videos.Add(JsonConvert.DeserializeObject<Video>(video.ToString()));
            }

            File.WriteAllText("../../index.html", GenerateHTML(videos));
        }

        public static void PrintVideoTitles(JToken videosJson)
        {
            var videoTitles = videosJson
                            .Select(mt => mt["title"]);

            foreach (var vt in videoTitles)
            {
                Console.WriteLine(vt);
            }
        }

        public static string RssToJson(string link, string filePath)
        {
            WebClient client = new WebClient();
            client.DownloadFile(link, filePath);

            var docXml = new XmlDocument();

            docXml.Load(filePath);

            return JsonConvert.SerializeXmlNode(docXml, Newtonsoft.Json.Formatting.Indented);
        }

        public static string GenerateHTML(List<Video> videos)
        {
            string htmlStart = @"<!DOCTYPE html>
                                <html lang=""en"">
                                <head>
                                    <meta charset=""UTF-8"">
                                    <title>Telerik RSS Videos</title>
                                </head>
                                <style type=""text/css"">
                                .video {
                                    float: left;
                                    width: 330px;
                                    height: 300px;
                                    padding: 10px;
                                    margin: 5px;
                                    background-color: green;
                                    border-radius: 15px
                                }
                                .title{
                                    color: white;
                                }
                                a{
                                    text-decoration: none;
                                }
                                </style>
                                <body>";

            string htmlEnd = @"</body></html>";

            string videoTemplate = @"<div class=""video"">
    <iframe width=""330"" height=""240"" src=""{0}"" frameborder=""0"" allowfullscreen></iframe>
    <a href=""{2}""><h3 class=""title"">{1}</h3></a></div>";

            var sBuilder = new StringBuilder();
            sBuilder.Append(htmlStart);
            foreach (var video in videos)
            {
                sBuilder.AppendFormat(videoTemplate, 
                    video.EmbedLink(),
                    video.Title,
                    video.Link.Href);
            }

            sBuilder.Append(htmlEnd);

            return sBuilder.ToString();
        }
    }
}