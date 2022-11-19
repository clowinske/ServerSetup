using ServerSetup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSetup.Engine
{
    public class SetupEngine
    {
        public ServerConfiguration ServerConfig = new ServerConfiguration();

        public void ServerSetup(ServerConfiguration ServerConfig)
        {
            this.ServerConfig = ServerConfig;
            GenerateBatFile();
            CreateEula();
            SetServerProperties();
            SetWhiteList();
        }

        public void GenerateBatFile()
        {
            string JarPath = ServerConfig.Files.First(x => x.Contains(".jar"));
            var JarFileName = Path.GetFileName(JarPath);
            Console.WriteLine(JarFileName);

            string Args = "java -Xmx16G -Xms8G -jar {0} nogui";
            Args = string.Format(Args, JarFileName);

            TextWriter txt = new StreamWriter(ServerConfig.FileDirectory + @"\Start.bat");
            txt.Write(Args);
            txt.Close();
        }

        public void CreateEula()
        {
            TextWriter txt = new StreamWriter(ServerConfig.FileDirectory + @"\eula.txt");
            txt.Write("eula=true");
            txt.Close();
        }

        public void SetServerProperties()
        {
            TextWriter txt = new StreamWriter(ServerConfig.FileDirectory + @"\server.properties");
            txt.WriteLine("allow-flight=true");
            txt.WriteLine("difficulty=hard");
            txt.WriteLine("enable-command-block=true");
            txt.WriteLine("enforce-whitelist=true");
            txt.WriteLine("spawn-protection=0");
            txt.WriteLine("white-list=false");
            txt.WriteLine(string.Format("server-port={0}", ServerConfig.Port));
            txt.WriteLine(string.Format("view-distance={0}", ServerConfig.ViewDistance));
            txt.Close();
        }

        public void SetWhiteList()
        {

        }
    }
}
