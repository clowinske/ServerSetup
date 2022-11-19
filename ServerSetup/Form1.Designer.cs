namespace ServerSetup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenServerFolder = new System.Windows.Forms.Button();
            this.ServerFolderDirTB = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.PortTB = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ViewDistanceTB = new System.Windows.Forms.TextBox();
            this.ViewDistanceLabel = new System.Windows.Forms.Label();
            this.SetupServerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenServerFolder
            // 
            this.OpenServerFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.OpenServerFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenServerFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenServerFolder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OpenServerFolder.Location = new System.Drawing.Point(619, 71);
            this.OpenServerFolder.Name = "OpenServerFolder";
            this.OpenServerFolder.Size = new System.Drawing.Size(151, 27);
            this.OpenServerFolder.TabIndex = 0;
            this.OpenServerFolder.Text = "Open Server Folder";
            this.OpenServerFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenServerFolder.UseVisualStyleBackColor = false;
            this.OpenServerFolder.Click += new System.EventHandler(this.OpenServerFolder_Click);
            // 
            // ServerFolderDirTB
            // 
            this.ServerFolderDirTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.ServerFolderDirTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerFolderDirTB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ServerFolderDirTB.Location = new System.Drawing.Point(12, 71);
            this.ServerFolderDirTB.Name = "ServerFolderDirTB";
            this.ServerFolderDirTB.Size = new System.Drawing.Size(601, 27);
            this.ServerFolderDirTB.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Title.Location = new System.Drawing.Point(320, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(181, 48);
            this.Title.TabIndex = 2;
            this.Title.Text = "Brett.AI";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortTB
            // 
            this.PortTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.PortTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortTB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PortTB.Location = new System.Drawing.Point(120, 130);
            this.PortTB.Name = "PortTB";
            this.PortTB.Size = new System.Drawing.Size(125, 20);
            this.PortTB.TabIndex = 3;
            this.PortTB.Text = "10";
            this.PortTB.TextChanged += new System.EventHandler(this.PortTB_TextChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortLabel.Location = new System.Drawing.Point(12, 130);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(35, 20);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "Port";
            // 
            // ViewDistanceTB
            // 
            this.ViewDistanceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.ViewDistanceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewDistanceTB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ViewDistanceTB.Location = new System.Drawing.Point(120, 171);
            this.ViewDistanceTB.Name = "ViewDistanceTB";
            this.ViewDistanceTB.Size = new System.Drawing.Size(125, 20);
            this.ViewDistanceTB.TabIndex = 6;
            this.ViewDistanceTB.Text = "16";
            this.ViewDistanceTB.TextChanged += new System.EventHandler(this.ViewDistanceTB_TextChanged);
            // 
            // ViewDistanceLabel
            // 
            this.ViewDistanceLabel.AutoSize = true;
            this.ViewDistanceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDistanceLabel.Location = new System.Drawing.Point(12, 171);
            this.ViewDistanceLabel.Name = "ViewDistanceLabel";
            this.ViewDistanceLabel.Size = new System.Drawing.Size(102, 20);
            this.ViewDistanceLabel.TabIndex = 7;
            this.ViewDistanceLabel.Text = "View Distance";
            // 
            // SetupServerBtn
            // 
            this.SetupServerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.SetupServerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetupServerBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetupServerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SetupServerBtn.Location = new System.Drawing.Point(320, 411);
            this.SetupServerBtn.Name = "SetupServerBtn";
            this.SetupServerBtn.Size = new System.Drawing.Size(181, 27);
            this.SetupServerBtn.TabIndex = 8;
            this.SetupServerBtn.Text = "Setup Server";
            this.SetupServerBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetupServerBtn.UseVisualStyleBackColor = false;
            this.SetupServerBtn.Click += new System.EventHandler(this.SetupServerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.SetupServerBtn);
            this.Controls.Add(this.ViewDistanceLabel);
            this.Controls.Add(this.ViewDistanceTB);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortTB);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ServerFolderDirTB);
            this.Controls.Add(this.OpenServerFolder);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brett.AI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OpenServerFolder;
        private TextBox ServerFolderDirTB;
        private Label Title;
        private TextBox PortTB;
        private Label PortLabel;
        private TextBox ViewDistanceTB;
        private Label ViewDistanceLabel;
        private Button SetupServerBtn;
    }
}