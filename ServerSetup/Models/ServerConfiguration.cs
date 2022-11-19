using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSetup.Models
{
    public class ServerConfiguration
    {
        public string FileDirectory { get; set; }
        public List<string> Files { get; set; }
        public int Port { get; set; }
        public int ViewDistance { get; set; }

        public ServerConfiguration() {
            Files = new List<string>();
        }
    }
}
