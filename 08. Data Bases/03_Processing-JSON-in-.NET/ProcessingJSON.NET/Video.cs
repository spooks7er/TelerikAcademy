using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProcessingJSON.NET
{
    public class Video
    {
        [JsonProperty("yt:videoId")]
        public string YtID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        public string EmbedLink()
        {
            return string.Format("http://www.youtube.com/embed/{0}?autoplay=0", this.YtID);
        }
    }
}
