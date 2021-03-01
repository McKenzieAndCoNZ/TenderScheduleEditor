using System;
using System.IO;
using System.Security.Cryptography;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class Checksum_Helper
    {
        public static string GetChecksum(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }
    }
}
