using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace API_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
            AllTheSingleLadies(appId, apiKey, email, pass);
        }

        private static void AllTheSingleLadies(string appID, string apiKey, string email, string pass)
        {
            var hasher = SHA1.Create();
            Session sessToken = null;
            byte[] arrayByte = System.Text.Encoding.UTF8.GetBytes(email + pass + appId + apiKey);
            arrayByte = hasher.ComputeHash(arrayByte, 0, arrayByte.Length);
            string hash = BitConverter.ToString(arrayByte);
            hash = hash.Replace("-", "");
            Console.WriteLine(hash);
            WebClient webCall = new WebClient();

            try
            {
                Stream palaute = webCall.OpenRead(apiUrl + "user/get_session_token.php?email=" + email + "&password=" + pass + "&application_id=" + appId + "&signature=" + hash);
                XmlSerializer serializer = new XmlSerializer(typeof(Session));
                sessToken = (Session)serializer.Deserialize(palaute);
            }

            catch (WebException e)
            {
                string responseText;
                using (var reader = new StreamReader(e.Response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                }

                Console.WriteLine(responseText);
            }

            try
            {
                Stream palaute = webCall.OpenRead(apiUrl + "user/get_info.php?session_token=" + sessToken.token);
                XmlSerializer serializer = new XmlSerializer(typeof(Call));
                Call olio = (Call)serializer.Deserialize(palaute);
                Console.WriteLine(olio.user.displayName);
            }

            catch { Console.WriteLine("Error"); }

            Console.Read();
        }

        //Fill out your own credential to try it out
        const string email = "";
        const string appId = "";
        const string apiUrl = "https://www.mediafire.com/api/1.1/";
        const string apiKey = "";
        const string pass = "";
    }
}
