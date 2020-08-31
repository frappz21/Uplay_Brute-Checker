using System;
using System.IO;

namespace WahtProject
{
    class Helper
    {
        public static string path1 = "Result\\" + "Uplay" + DateTime.Now.ToString("_yyyy.MM.dd_HH-mm");

        public static string path2 = path1 + "\\Sort game";

        public static string Pars(string strSource, string strStart, string strEnd, int startPos = 0) //method for parsing answer
        {
            string result = string.Empty;
            try
            {
                int length = strStart.Length,
                    num = strSource.IndexOf(strStart, startPos),
                    num2 = strSource.IndexOf(strEnd, num + length);
                if (num != -1 & num2 != -1)
                    result = strSource.Substring(num + length, num2 - (num + length));
            }
            catch (Exception ex) { File.WriteAllText("ParsError.txt", ex.Message); }
            return result;
        }
    }
}
