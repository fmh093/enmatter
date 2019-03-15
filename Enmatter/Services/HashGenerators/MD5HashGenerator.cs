using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using System.Web;
using Encoder = Enmatter.Models.Encoder;

namespace Enmatter.Encoders
{
    class MD5HashGenerator : HashGenerator
    {
        public MD5HashGenerator()
        {
            Name = "MD5 Hash Generator";
        }

        public override string Translate(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            
            byte[] result = md5.Hash;

            var strBuilder = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
                strBuilder.Append(result[i].ToString("x2"));

            return strBuilder.ToString();
        }
    }
}
