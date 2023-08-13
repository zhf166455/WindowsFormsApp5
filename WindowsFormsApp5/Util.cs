using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp5
{
    internal class Util
    {
        
        private static string ROOTURL = "http://127.0.0.1:16646";
        public const string U_LOGIN = "/base/login";

        public static string G_uid = "";
        public static int G_lv = 0;
        public static string G_name = "";
        public static string G_did = "";
        public static string G_ad = "";
        public static string G_dname = "";
        public static string G_token = "";
        public static string G_ver = "v 1.0.0";
        public static string G_page = "导航";
        public static string G_opt = "新建";

        public static void SetRootUrl(string root)
        {
            ROOTURL ="http://"+ root+":16646";
        }

        public static string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static string httpget(string url,string ck=null)
        {
            try
            {
                RestClient client = new RestClient(ROOTURL);
                RestRequest requestGet = new RestRequest(url, Method.Get);
                if (string.IsNullOrEmpty(ck) == false)
                {
                    requestGet.AddHeader("Cookie", ck);
                }
                RestResponse response = client.Execute(requestGet);
                string contentGet = response.Content;
                return contentGet;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                return string.Empty;
            }

        }
        public static string httppost(string url,ref string body,string ck=null)
        {
            try
            {
                RestClient client = new RestClient(ROOTURL);
                RestRequest requestGet = new RestRequest(url, Method.Post);
                if (string.IsNullOrEmpty(ck) == false)
                {
                    requestGet.AddHeader("Cookie", ck);
                }
                requestGet.AddBody(body);
                RestResponse response = client.Execute(requestGet);
                string contentGet = response.Content;
                if (contentGet == null)
                {
                    return string.Empty;
                }
                return contentGet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }
        // 使用Base64编码加密字符串
        public static string EncryptString(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            string encryptedText = Convert.ToBase64String(plainBytes);
            return encryptedText;
        }

        // 使用Base64解码解密字符串
        public static string DecryptString(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            string decryptedText = Encoding.UTF8.GetString(encryptedBytes);
            return decryptedText;
        }
        //取文本中间
        public static string midstr(ref string str,string lstr,string rstr)
        {
            int startIndex = str.IndexOf(lstr); // 查找"c"的索引
            int endIndex = str.IndexOf(rstr); // 查找"f"的索引
            string middleText = str.Substring(startIndex + 1, endIndex - startIndex - 1);
            return middleText;
        }
        //取文本左边
        public static string leftstr(ref string str, int len)
        {
            if (str == null || str.Length < len)
            {
                return string.Empty;
            }

            return str.Substring(0, len);
        }
        //取文本右边
        public static string rightstr(ref string str, int len)
        {
            if (str == null || str.Length < len)
            {
                return string.Empty;
            }

            return str.Substring(str.Length - len, len);
        }
        
    }
}
