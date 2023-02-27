using System;
using System.Text;

namespace Генератор_паролей
{
    public static class GenPass
    {
        static Random  rnd = new Random();

        public static string CreatePassword(int length = 8)
        {
            const string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }
    }
}
