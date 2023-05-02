using System.Security.Cryptography;
using System.Text;

namespace _11laba
{
    public class Hashing
    {
        private string stringToHash { get; set; }
        public Hashing(string answer) 
        {
            stringToHash = answer;
        }
        public string ToHash()
        {
            byte[] messageBytes = Encoding.ASCII.GetBytes(stringToHash);
            byte[] hashBytes = MD5.HashData(messageBytes);
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");
            return hashString;
        }
    }
}
