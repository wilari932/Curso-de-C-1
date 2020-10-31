using System;
using System.Net;
using System.Web;

namespace GoogleTranslate
{
    public class Translator
    {

        public string Translate(string text, string fromLanguage = "es", string toLanguage = "en")
        {
            using (WebClient client = new WebClient())
            {


                string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(text)}";

                var result = client.DownloadString(url);
                try
                {

                    return result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                }
                catch
                {
                    throw new Exception("error with the translator");
                }

            }
        }
    }
}
