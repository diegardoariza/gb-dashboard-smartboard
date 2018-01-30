using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace GBDashboard.Utils
{
    internal static class StringManager
    {
        internal static string Encrypt(string ToEncrypt)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(ToEncrypt));
        }
        internal static string Decrypt(string cypherString)
        {
            return Encoding.ASCII.GetString(Convert.FromBase64String(cypherString));
        }
    }
}