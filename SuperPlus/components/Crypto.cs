/*****************************************
 *  Use for Ecrypting Decrypting Password
 *****************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SuperPlus.components
{
    class Crypto
    {
        private String hash;

        public String Send(String encode)
        {
            try
            {
                SHA512 crypt = SHA512.Create();
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] merge = encoder.GetBytes(encode);
                crypt.ComputeHash(merge);
                hash = Convert.ToBase64String(crypt.Hash);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return hash;
        }

        public String Return()
        {
            return hash;
        }
    }
}
