namespace client_tutorial
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.btnStart = new System.Windows.Forms.Button();
            this.tmr_scoreUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblTimerMin = new System.Windows.Forms.Label();
            this.lblTimerSec = new System.Windows.Forms.Label();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lsb_info = new System.Windows.Forms.ListBox();
            this.lbl_numConnStatic = new System.Windows.Forms.Label();
            this.lbl_ip_static = new System.Windows.Forms.Label();
            this.lbl_portnum_static = new System.Windows.Forms.Label();
            this.lbl_numConn = new System.Windows.Forms.Label();
            this.lbl_winnerScore = new System.Windows.Forms.Label();
            this.btn_upTri1 = new System.Windows.Forms.Button();
            this.btn_upTri2 = new System.Windows.Forms.Button();
            this.btn_downTri1 = new System.Windows.Forms.Button();
            this.btn_downTri2 = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.SocketWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDomainNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_winnerid = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStart.Location = new System.Drawing.Point(101, 272);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmr_scoreUpdate
            // 
            this.tmr_scoreUpdate.Interval = 200;
            this.tmr_scoreUpdate.Tick += new System.EventHandler(this.tmr_scoreUpdate_Tick);
            // 
            // lblTimerMin
            // 
            this.lblTimerMin.AutoSize = true;
            this.lblTimerMin.Font = new System.Drawing.Font("CATIA Symbols", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTimerMin.Location = new System.Drawing.Point(95, 117);
            this.lblTimerMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerMin.Name = "lblTimerMin";
            this.lblTimerMin.Size = new System.Drawing.Size(108, 94);
            this.lblTimerMin.TabIndex = 2;
            this.lblTimerMin.Text = "59";
            // 
            // lblTimerSec
            // 
            this.lblTimerSec.AutoSize = true;
            this.lblTimerSec.Font = new System.Drawing.Font("CATIA Symbols", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTimerSec.Location = new System.Drawing.Point(236, 117);
            this.lblTimerSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimerSec.Name = "lblTimerSec";
            this.lblTimerSec.Size = new System.Drawing.Size(108, 94);
            this.lblTimerSec.TabIndex = 3;
            this.lblTimerSec.Text = "59";
            this.lblTimerSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_winner.Location = new System.Drawing.Point(98, 348);
            this.lbl_winner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(82, 24);
            this.lbl_winner.TabIndex = 4;
            this.lbl_winner.Text = "Winner ID:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("CATIA Symbols", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblCol.Location = new System.Drawing.Point(192, 117);
            this.lblCol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(59, 94);
            this.lblCol.TabIndex = 5;
            this.lblCol.Text = ":";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnReset.Location = new System.Drawing.Point(242, 272);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lsb_info
            // 
            this.lsb_info.Font = new System.Drawing.Font("CATIA Symbols", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lsb_info.FormattingEnabled = true;
            this.lsb_info.ItemHeight = 18;
            this.lsb_info.Location = new System.Drawing.Point(451, 40);
            this.lsb_info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lsb_info.Name = "lsb_info";
            this.lsb_info.Size = new System.Drawing.Size(306, 292);
            this.lsb_info.TabIndex = 9;
            // 
            // lbl_numConnStatic
            // 
            this.lbl_numConnStatic.AutoSize = true;
            this.lbl_numConnStatic.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_numConnStatic.Location = new System.Drawing.Point(445, 348);
            this.lbl_numConnStatic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numConnStatic.Name = "lbl_numConnStatic";
            this.lbl_numConnStatic.Size = new System.Drawing.Size(178, 24);
            this.lbl_numConnStatic.TabIndex = 10;
            this.lbl_numConnStatic.Text = "Number of Connections:";
            // 
            // lbl_ip_static
            // 
            this.lbl_ip_static.AutoSize = true;
            this.lbl_ip_static.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_ip_static.Location = new System.Drawing.Point(445, 378);
            this.lbl_ip_static.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ip_static.Name = "lbl_ip_static";
            this.lbl_ip_static.Size = new System.Drawing.Size(90, 24);
            this.lbl_ip_static.TabIndex = 11;
            this.lbl_ip_static.Text = "IP Address:";
            // 
            // lbl_portnum_static
            // 
            this.lbl_portnum_static.AutoSize = true;
            this.lbl_portnum_static.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_portnum_static.Location = new System.Drawing.Point(445, 407);
            this.lbl_portnum_static.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_portnum_static.Name = "lbl_portnum_static";
            this.lbl_portnum_static.Size = new System.Drawing.Size(102, 24);
            this.lbl_portnum_static.TabIndex = 12;
            this.lbl_portnum_static.Text = "Port Number:";
            // 
            // lbl_numConn
            // 
            this.lbl_numConn.AutoSize = true;
            this.lbl_numConn.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_numConn.Location = new System.Drawing.Point(636, 348);
            this.lbl_numConn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numConn.Name = "lbl_numConn";
            this.lbl_numConn.Size = new System.Drawing.Size(19, 24);
            this.lbl_numConn.TabIndex = 13;
            this.lbl_numConn.Text = "0";
            // 
            // lbl_winnerScore
            // 
            this.lbl_winnerScore.AutoSize = true;
            this.lbl_winnerScore.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_winnerScore.Location = new System.Drawing.Point(98, 375);
            this.lbl_winnerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_winnerScore.Name = "lbl_winnerScore";
            this.lbl_winnerScore.Size = new System.Drawing.Size(55, 24);
            this.lbl_winnerScore.TabIndex = 20;
            this.lbl_winnerScore.Text = "Score:";
            // 
            // btn_upTri1
            // 
            this.btn_upTri1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upTri1.Location = new System.Drawing.Point(127, 99);
            this.btn_upTri1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_upTri1.Name = "btn_upTri1";
            this.btn_upTri1.Size = new System.Drawing.Size(37, 32);
            this.btn_upTri1.TabIndex = 16;
            this.btn_upTri1.Text = " ▲";
            this.btn_upTri1.UseVisualStyleBackColor = true;
            this.btn_upTri1.Click += new System.EventHandler(this.btn_upTri1_Click);
            // 
            // btn_upTri2
            // 
            this.btn_upTri2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upTri2.Location = new System.Drawing.Point(268, 99);
            this.btn_upTri2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_upTri2.Name = "btn_upTri2";
            this.btn_upTri2.Size = new System.Drawing.Size(37, 32);
            this.btn_upTri2.TabIndex = 23;
            this.btn_upTri2.Text = " ▲";
            this.btn_upTri2.UseVisualStyleBackColor = true;
            this.btn_upTri2.Click += new System.EventHandler(this.btn_upTri2_Click);
            // 
            // btn_downTri1
            // 
            this.btn_downTri1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downTri1.Location = new System.Drawing.Point(127, 203);
            this.btn_downTri1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_downTri1.Name = "btn_downTri1";
            this.btn_downTri1.Size = new System.Drawing.Size(37, 32);
            this.btn_downTri1.TabIndex = 24;
            this.btn_downTri1.Text = " ▼";
            this.btn_downTri1.UseVisualStyleBackColor = true;
            this.btn_downTri1.Click += new System.EventHandler(this.btn_downTri1_Click);
            // 
            // btn_downTri2
            // 
            this.btn_downTri2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downTri2.Location = new System.Drawing.Point(268, 203);
            this.btn_downTri2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_downTri2.Name = "btn_downTri2";
            this.btn_downTri2.Size = new System.Drawing.Size(37, 32);
            this.btn_downTri2.TabIndex = 25;
            this.btn_downTri2.Text = " ▼";
            this.btn_downTri2.UseVisualStyleBackColor = true;
            this.btn_downTri2.Click += new System.EventHandler(this.btn_downTri2_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Font = new System.Drawing.Font("CATIA Symbols", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txt_ip.Location = new System.Drawing.Point(638, 378);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 23);
            this.txt_ip.TabIndex = 26;
            this.txt_ip.Text = "0.0.0.0";
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("CATIA Symbols", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txt_port.Location = new System.Drawing.Point(638, 407);
            this.txt_port.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 23);
            this.txt_port.TabIndex = 27;
            this.txt_port.Text = "7";
            // 
            // SocketWorker
            // 
            this.SocketWorker.WorkerSupportsCancellation = true;
            this.SocketWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SocketWorker_DoWork);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(100, 26);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDomainNameToolStripMenuItem,
            this.showIPToolStripMenuItem,
            this.exportResultsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitProgramToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("CATIA Symbols", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // showDomainNameToolStripMenuItem
            // 
            this.showDomainNameToolStripMenuItem.Name = "showDomainNameToolStripMenuItem";
            this.showDomainNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDomainNameToolStripMenuItem.Text = "Show Domain Name";
            this.showDomainNameToolStripMenuItem.Click += new System.EventHandler(this.showDomainNameToolStripMenuItem_Click);
            // 
            // showIPToolStripMenuItem
            // 
            this.showIPToolStripMenuItem.Name = "showIPToolStripMenuItem";
            this.showIPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showIPToolStripMenuItem.Text = "Show Current IP";
            this.showIPToolStripMenuItem.Click += new System.EventHandler(this.showIPToolStripMenuItem_Click);
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportResultsToolStripMenuItem.Text = "Export Results";
            this.exportResultsToolStripMenuItem.Click += new System.EventHandler(this.exportResultsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitProgramToolStripMenuItem
            // 
            this.quitProgramToolStripMenuItem.Name = "quitProgramToolStripMenuItem";
            this.quitProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitProgramToolStripMenuItem.Text = "Quit";
            this.quitProgramToolStripMenuItem.Click += new System.EventHandler(this.quitProgramToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("CATIA Symbols", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lbl_winnerid
            // 
            this.lbl_winnerid.AutoSize = true;
            this.lbl_winnerid.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_winnerid.Location = new System.Drawing.Point(194, 348);
            this.lbl_winnerid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_winnerid.Name = "lbl_winnerid";
            this.lbl_winnerid.Size = new System.Drawing.Size(36, 24);
            this.lbl_winnerid.TabIndex = 31;
            this.lbl_winnerid.Text = "N/A";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("CATIA Symbols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_score.Location = new System.Drawing.Point(194, 375);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(36, 24);
            this.lbl_score.TabIndex = 32;
            this.lbl_score.Text = "N/A";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_winnerid);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_downTri2);
            this.Controls.Add(this.btn_downTri1);
            this.Controls.Add(this.btn_upTri2);
            this.Controls.Add(this.lbl_winnerScore);
            this.Controls.Add(this.btn_upTri1);
            this.Controls.Add(this.lbl_numConn);
            this.Controls.Add(this.lbl_portnum_static);
            this.Controls.Add(this.lbl_ip_static);
            this.Controls.Add(this.lbl_numConnStatic);
            this.Controls.Add(this.lsb_info);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.lblTimerSec);
            this.Controls.Add(this.lblTimerMin);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_main";
            this.Text = "Server Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmr_scoreUpdate;
        private System.Windows.Forms.Label lblTimerMin;
        private System.Windows.Forms.Label lblTimerSec;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lsb_info;
        private System.Windows.Forms.Label lbl_numConnStatic;
        private System.Windows.Forms.Label lbl_ip_static;
        private System.Windows.Forms.Label lbl_portnum_static;
        private System.Windows.Forms.Label lbl_numConn;
        private System.Windows.Forms.Label lbl_winnerScore;
        private System.Windows.Forms.Button btn_upTri1;
        private System.Windows.Forms.Button btn_upTri2;
        private System.Windows.Forms.Button btn_downTri1;
        private System.Windows.Forms.Button btn_downTri2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.ComponentModel.BackgroundWorker SocketWorker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDomainNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lbl_winnerid;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.ToolStripMenuItem exportResultsToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

