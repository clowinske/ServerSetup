namespace ServerSetup
{
    public partial class Form1 : Form
    {
        public string ServerFolderDir = @"C:\Users\dylon\OneDrive\Documents\Server";
        public string[] Files { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenServerFolder_Click(object sender, EventArgs e)
        {
            using (var browserDialog = new FolderBrowserDialog())
            {
                browserDialog.InitialDirectory = ServerFolderDir;
                DialogResult result = browserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
                {
                    Files = Directory.GetFiles(browserDialog.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
                foreach(var file in Files)
                {
                    Console.Write(file);

                }
                //Console.Write(browserDialog.SelectedPath);
                textBox2.Text = browserDialog.SelectedPath;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}