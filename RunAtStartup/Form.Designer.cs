namespace RunAtStartup
{
    partial class form
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
            this.label1 = new System.Windows.Forms.Label();
            this.exepath = new System.Windows.Forms.TextBox();
            this.startup = new System.Windows.Forms.RadioButton();
            this.whenilogin = new System.Windows.Forms.RadioButton();
            this.startuponce = new System.Windows.Forms.RadioButton();
            this.wheniloginonce = new System.Windows.Forms.RadioButton();
            this.donebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.appname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listaddbutton = new System.Windows.Forms.Button();
            this.add_panel = new System.Windows.Forms.Panel();
            this.list_panel = new System.Windows.Forms.Panel();
            this.exelist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetfile = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.add_panel.SuspendLayout();
            this.list_panel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application Executable:";
            // 
            // exepath
            // 
            this.exepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.exepath.Location = new System.Drawing.Point(4, 92);
            this.exepath.Name = "exepath";
            this.exepath.Size = new System.Drawing.Size(725, 26);
            this.exepath.TabIndex = 1;
            this.exepath.Text = "Click To Select";
            this.exepath.Click += new System.EventHandler(this.exepath_Click);
            // 
            // startup
            // 
            this.startup.AutoSize = true;
            this.startup.Checked = true;
            this.startup.Location = new System.Drawing.Point(18, 34);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(222, 22);
            this.startup.TabIndex = 2;
            this.startup.TabStop = true;
            this.startup.Text = "Run When Windows Starts Up";
            this.startup.UseVisualStyleBackColor = true;
            // 
            // whenilogin
            // 
            this.whenilogin.AutoSize = true;
            this.whenilogin.Location = new System.Drawing.Point(18, 62);
            this.whenilogin.Name = "whenilogin";
            this.whenilogin.Size = new System.Drawing.Size(152, 22);
            this.whenilogin.TabIndex = 3;
            this.whenilogin.TabStop = true;
            this.whenilogin.Text = "Run When I Log In";
            this.whenilogin.UseVisualStyleBackColor = true;
            // 
            // startuponce
            // 
            this.startuponce.AutoSize = true;
            this.startuponce.Location = new System.Drawing.Point(18, 90);
            this.startuponce.Name = "startuponce";
            this.startuponce.Size = new System.Drawing.Size(273, 22);
            this.startuponce.TabIndex = 4;
            this.startuponce.TabStop = true;
            this.startuponce.Text = "Run When Windows Starts Up (Once)";
            this.startuponce.UseVisualStyleBackColor = true;
            // 
            // wheniloginonce
            // 
            this.wheniloginonce.AutoSize = true;
            this.wheniloginonce.Location = new System.Drawing.Point(18, 118);
            this.wheniloginonce.Name = "wheniloginonce";
            this.wheniloginonce.Size = new System.Drawing.Size(203, 22);
            this.wheniloginonce.TabIndex = 5;
            this.wheniloginonce.TabStop = true;
            this.wheniloginonce.Text = "Run When I Log In (Once)";
            this.wheniloginonce.UseVisualStyleBackColor = true;
            // 
            // donebtn
            // 
            this.donebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.donebtn.Location = new System.Drawing.Point(662, 452);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(56, 29);
            this.donebtn.TabIndex = 6;
            this.donebtn.Text = "Add";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.Location = new System.Drawing.Point(658, 513);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(99, 38);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Close";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // appname
            // 
            this.appname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.appname.Location = new System.Drawing.Point(4, 32);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(725, 26);
            this.appname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application Name:";
            // 
            // listaddbutton
            // 
            this.listaddbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listaddbutton.Location = new System.Drawing.Point(22, 513);
            this.listaddbutton.Name = "listaddbutton";
            this.listaddbutton.Size = new System.Drawing.Size(99, 38);
            this.listaddbutton.TabIndex = 10;
            this.listaddbutton.Text = "List";
            this.listaddbutton.UseVisualStyleBackColor = true;
            this.listaddbutton.Click += new System.EventHandler(this.listaddbutton_Click);
            // 
            // add_panel
            // 
            this.add_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.add_panel.BackColor = System.Drawing.Color.White;
            this.add_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_panel.Controls.Add(this.resetfile);
            this.add_panel.Controls.Add(this.groupBox1);
            this.add_panel.Controls.Add(this.label2);
            this.add_panel.Controls.Add(this.label1);
            this.add_panel.Controls.Add(this.appname);
            this.add_panel.Controls.Add(this.exepath);
            this.add_panel.Controls.Add(this.donebtn);
            this.add_panel.Location = new System.Drawing.Point(24, 12);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(733, 495);
            this.add_panel.TabIndex = 11;
            // 
            // list_panel
            // 
            this.list_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.list_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_panel.Controls.Add(this.exelist);
            this.list_panel.Controls.Add(this.toolStrip1);
            this.list_panel.Location = new System.Drawing.Point(24, 12);
            this.list_panel.Name = "list_panel";
            this.list_panel.Size = new System.Drawing.Size(733, 495);
            this.list_panel.TabIndex = 12;
            this.list_panel.Visible = false;
            // 
            // exelist
            // 
            this.exelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.exelist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exelist.FullRowSelect = true;
            this.exelist.Location = new System.Drawing.Point(0, 25);
            this.exelist.Name = "exelist";
            this.exelist.Size = new System.Drawing.Size(731, 468);
            this.exelist.TabIndex = 0;
            this.exelist.UseCompatibleStateImageBehavior = false;
            this.exelist.View = System.Windows.Forms.View.Details;
            this.exelist.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.exelist_ColumnWidthChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Application Path";
            this.columnHeader2.Width = 431;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(731, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RunAtStartup.Properties.Resources.delete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Delete";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startup);
            this.groupBox1.Controls.Add(this.wheniloginonce);
            this.groupBox1.Controls.Add(this.startuponce);
            this.groupBox1.Controls.Add(this.whenilogin);
            this.groupBox1.Location = new System.Drawing.Point(15, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "When Should This Application Run?";
            // 
            // resetfile
            // 
            this.resetfile.BackgroundImage = global::RunAtStartup.Properties.Resources.delete;
            this.resetfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetfile.Location = new System.Drawing.Point(704, 93);
            this.resetfile.Name = "resetfile";
            this.resetfile.Size = new System.Drawing.Size(24, 24);
            this.resetfile.TabIndex = 11;
            this.resetfile.UseVisualStyleBackColor = true;
            this.resetfile.Visible = false;
            this.resetfile.Click += new System.EventHandler(this.resetfile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Location = new System.Drawing.Point(127, 523);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(525, 19);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.fatihbakir.net";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.list_panel);
            this.Controls.Add(this.listaddbutton);
            this.Controls.Add(this.cancelbtn);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(469, 423);
            this.Name = "form";
            this.ShowIcon = false;
            this.Text = "RunAtStartup";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResizeBegin += new System.EventHandler(this.form_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.form_ResizeEnd);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            this.list_panel.ResumeLayout(false);
            this.list_panel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exepath;
        private System.Windows.Forms.RadioButton startup;
        private System.Windows.Forms.RadioButton whenilogin;
        private System.Windows.Forms.RadioButton startuponce;
        private System.Windows.Forms.RadioButton wheniloginonce;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.TextBox appname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button listaddbutton;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.Panel list_panel;
        private System.Windows.Forms.ListView exelist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

