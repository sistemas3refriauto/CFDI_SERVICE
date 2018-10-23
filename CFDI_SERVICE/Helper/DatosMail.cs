using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFDI_SERVICE
{
    class DatosMail
    {
        public string from { get; set; }
        public string to { get; set; }
        public string body { get; set; }
        public string FromPassword { get; set; }
        public string subjet { set; get; }
        public string host { set; get; }
        public int port { set; get; }
        public bool enableSSl { set; get; }
        public bool UseDefaultCredentials { set; get; }
    }
}
