namespace Flatout2Launcher
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.textBoxClient_ServerIP = new System.Windows.Forms.TextBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.labelMyIP = new System.Windows.Forms.Label();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.tabPageSinglePlayer = new System.Windows.Forms.TabPage();
            this.pictureBoxFlatOutLogo = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.tabPageOptions.SuspendLayout();
            this.tabPageSinglePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlatOutLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(12, 292);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(241, 292);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Go!";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabClient);
            this.mainTabControl.Controls.Add(this.tabServer);
            this.mainTabControl.Controls.Add(this.tabPageOptions);
            this.mainTabControl.Controls.Add(this.tabPageSinglePlayer);
            this.mainTabControl.Location = new System.Drawing.Point(12, 171);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(304, 115);
            this.mainTabControl.TabIndex = 2;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.textBoxClient_ServerIP);
            this.tabClient.Controls.Add(this.labelServerIP);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(296, 89);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Join";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // textBoxClient_ServerIP
            // 
            this.textBoxClient_ServerIP.Location = new System.Drawing.Point(121, 34);
            this.textBoxClient_ServerIP.MaxLength = 15;
            this.textBoxClient_ServerIP.Name = "textBoxClient_ServerIP";
            this.textBoxClient_ServerIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxClient_ServerIP.TabIndex = 1;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(61, 37);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(54, 13);
            this.labelServerIP.TabIndex = 0;
            this.labelServerIP.Text = "Server IP:";
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.comboBox1);
            this.tabServer.Controls.Add(this.labelMyIP);
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(296, 89);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "Host";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // labelMyIP
            // 
            this.labelMyIP.AutoSize = true;
            this.labelMyIP.Location = new System.Drawing.Point(6, 37);
            this.labelMyIP.Name = "labelMyIP";
            this.labelMyIP.Size = new System.Drawing.Size(37, 13);
            this.labelMyIP.TabIndex = 1;
            this.labelMyIP.Text = "My IP:";
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Controls.Add(this.label1);
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(296, 89);
            this.tabPageOptions.TabIndex = 2;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // tabPageSinglePlayer
            // 
            this.tabPageSinglePlayer.Controls.Add(this.label2);
            this.tabPageSinglePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSinglePlayer.Name = "tabPageSinglePlayer";
            this.tabPageSinglePlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSinglePlayer.Size = new System.Drawing.Size(296, 89);
            this.tabPageSinglePlayer.TabIndex = 3;
            this.tabPageSinglePlayer.Text = "Single Player";
            this.tabPageSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFlatOutLogo
            // 
            this.pictureBoxFlatOutLogo.Image = global::Flatout2Launcher.Properties.Resources.Bitmap_130;
            this.pictureBoxFlatOutLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlatOutLogo.InitialImage")));
            this.pictureBoxFlatOutLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFlatOutLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFlatOutLogo.MaximumSize = new System.Drawing.Size(327, 168);
            this.pictureBoxFlatOutLogo.MinimumSize = new System.Drawing.Size(327, 168);
            this.pictureBoxFlatOutLogo.Name = "pictureBoxFlatOutLogo";
            this.pictureBoxFlatOutLogo.Size = new System.Drawing.Size(327, 168);
            this.pictureBoxFlatOutLogo.TabIndex = 3;
            this.pictureBoxFlatOutLogo.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on Go to change FlatOut 2 Graphics settings.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Click on Go to play alone.";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(328, 326);
            this.Controls.Add(this.pictureBoxFlatOutLogo);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 364);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 364);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flatout 2 Launcher";
            this.mainTabControl.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.tabServer.PerformLayout();
            this.tabPageOptions.ResumeLayout(false);
            this.tabPageOptions.PerformLayout();
            this.tabPageSinglePlayer.ResumeLayout(false);
            this.tabPageSinglePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlatOutLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TextBox textBoxClient_ServerIP;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.Label labelMyIP;
        private System.Windows.Forms.TabPage tabPageOptions;
        private System.Windows.Forms.TabPage tabPageSinglePlayer;
        private System.Windows.Forms.PictureBox pictureBoxFlatOutLogo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

