using ServerSetup.Models;
namespace ServerSetup
{
    public partial class Form1 : Form
    {
        public ServerConfiguration ServerConfig = new ServerConfiguration();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenServerFolder_Click(object sender, EventArgs e)
        {
            using (var browserDialog = new FolderBrowserDialog())
            {
                browserDialog.InitialDirectory = Defaults.InitialDirectory;
                DialogResult result = browserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
                {
                    ServerConfig.Files = Directory.GetFiles(browserDialog.SelectedPath).ToList();
                }
                
                ServerFolderDirTB.Text = browserDialog.SelectedPath;
                ServerConfig.FileDirectory = browserDialog.SelectedPath;
            }
        }

        private void SetupServerBtn_Click(object sender, EventArgs e)
        {
            Engine.SetupEngine engine = new Engine.SetupEngine();
            engine.ServerSetup(ServerConfig);
        }

        private void PortTB_TextChanged(object sender, EventArgs e)
        {
            ServerConfig.Port = int.Parse(PortTB.Text.Trim());
        }

        private void ViewDistanceTB_TextChanged(object sender, EventArgs e)
        {
            ServerConfig.ViewDistance = int.Parse(ViewDistanceTB.Text.Trim());
        }
    }
}