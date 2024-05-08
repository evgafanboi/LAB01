using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB03
{
    [Serializable]
    internal class FileMessage
    {
        public byte[] file_bytes;
        public string receiver;
        public string sender;
        public string file_name;
    }
}
