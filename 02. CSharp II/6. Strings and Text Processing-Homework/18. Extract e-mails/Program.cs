using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Problem 18. Extract e-mails
//• Write a program for extracting all email addresses from given text.
//• All sub-strings that match the format  <identifier>@<host>.<domain>  should be recognized as emails.
namespace _18.Extract_e_mails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"fsf@dfkgj.com asdasdasd asdasd
8764x1vdgv.fsf@athene.jamux.com asdasdasdasd
fsf@ns.biwa.ne.jp asdasdasdasdasdasd
info@mail.dfkgj.com asdqqdqdsdasda";

            MatchCollection collection = default(MatchCollection);
            
            string emailRegex =
@"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"+
@"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."+
@"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"+
@"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            collection = Regex.Matches(text, emailRegex);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
