using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPChat.Common
{
    internal class ConnectionSchemes
    {

        public enum schemes
        {
            NoEncryption =0,
            RSAWithoutDiffieHellman=1
        }
    }
}
