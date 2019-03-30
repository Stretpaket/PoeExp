using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;


namespace poexp
{
    class CharacterHandler
    {
        string accountName, characterName;
        string URL = "https://pathofexile.com/character-window/get-items?character=";
        public CharacterHandler(string accountName, string characterName)
        {
            URL += characterName + "&accountName=" + accountName;
            this.accountName = accountName;
            this.characterName = characterName;
        }

        /* Borrowed from https://stackoverflow.com/questions/27108264/c-sharp-how-to-properly-make-a-http-web-get-request */
        public string fetchCharacterData(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public Dictionary<string,string> getCharacterInfo()
        {
            JObject response = JObject.Parse(fetchCharacterData(URL));
            Dictionary<string, string> charData = new Dictionary<string, string>();
            charData.Add("name", (string)response["character"]["name"]);
            charData.Add("class", (string)response["character"]["class"]);
            charData.Add("level", (string)response["character"]["level"]);
            charData.Add("xp", (string)response["character"]["experience"]);
            return charData;
        }

        public long getCurrentXP()
        {
            return long.Parse(getCharacterInfo()["xp"]);
        }

        
    }
}
