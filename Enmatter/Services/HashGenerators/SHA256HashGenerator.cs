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
    class SHA256HashGenerator : HashGenerator
    {
        public SHA256HashGenerator()
        {
            Name = "SHA-256 Hash Generator";
        }

        public override string Translate(string input)
        {
            using (var sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                var builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
