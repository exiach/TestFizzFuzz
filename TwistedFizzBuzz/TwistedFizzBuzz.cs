using System.Net;
using System.Text.Json.Nodes;

namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzz
    {
        public static void RangePrintBuzzFizz(string range)
        {
            if (TryParseRange(range, out int start, out int end))
            {
                GenerateListFizzBuzz(start, end);
            };

        }
        public static void GenerateListFizzBuzz(int start, int end)
        {
            if (start > end)
            {
                for (int i = start; i >= end; i--)
                {
                    PrintFizzBuzz(i);
                }
                return;
            }
            for (int i = start; i <= end; i++)
            {
                PrintFizzBuzz(i);
            }
        }

        public static void PrintFizzBuzz(int n)
        {
            bool isMultThree = IsMultThree(n);
            bool isMultFive = IsMultFive(n);
            string result = "";
           
            if (isMultThree)
            {
                result+= "Fizz";
            }
            if (isMultFive)
            {
                result+= "Buzz";
            }
            Console.WriteLine(result != "" ? result : n);
        }

        public static void GetRandonFizzBuzzToken()
        {
            var url = "https://rich-red-cocoon-veil.cyclic.app/random";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            var jsonObject = JsonObject.Parse(responseBody);
                            Console.WriteLine(jsonObject["multiple"] + ": " + jsonObject["word"]);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static bool IsMultThree(int n)
        {
            return n % 3 == 0;
        }

        private static bool IsMultFive(int n)
        {
            return n % 5 == 0;
        }

        private static bool TryParseRange(string range, out int start, out int end)
        {
            start = 0;
            end = 0;
            char[] charsToTrim = { ',' };
            string rangeClean = range.Trim(charsToTrim);
            string[] rangeParts = range.Replace(",", "").Split('-');
            if (rangeParts.Length == 4)
            {
                if (rangeParts[0] == "(" && !int.TryParse("-" + rangeParts[1].Trim(')'), out start))
                {
                    return false;
                }
                if (rangeParts[0] == "(" && rangeParts[2] == "(" && !int.TryParse("-" + rangeParts[3].Trim(')'), out end))
                {
                    return false;
                }
                return true;    
            }
            if (rangeParts.Length == 3)
            {
                if (rangeParts[0] == "(" && !int.TryParse("-" + rangeParts[1].Trim(')'), out start))
                {
                    return false;
                }
                if (rangeParts[0] != "(" && !int.TryParse(rangeParts[0], out start))
                {
                    return false;
                }
                if (rangeParts[0] != "(" && rangeParts[1] == "(" && !int.TryParse("-" + rangeParts[2].Trim(')'), out end))
                {
                    return false;
                }
                if (rangeParts[0] == "(" && rangeParts[1] != "(" && !int.TryParse(rangeParts[2], out end))
                {
                    return false;
                }
                return true;
            }

            if (!int.TryParse(rangeParts[0], out start) || !int.TryParse(rangeParts[1], out end))
            {   
                return false;
            }
            return true;
        }
    }
}