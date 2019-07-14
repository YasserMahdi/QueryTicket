namespace Query_Ticket.PL
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSelectPath = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtpath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "انشاء نسخة احتياطية";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(155, 254);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(370, 34);
            this.bunifuFlatButton2.TabIndex = 24;
            this.bunifuFlatButton2.Text = "انشاء نسخة احتياطية";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectPath.BorderRadius = 0;
            this.btnSelectPath.ButtonText = "... ";
            this.btnSelectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPath.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelectPath.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelectPath.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSelectPath.Iconimage")));
            this.btnSelectPath.Iconimage_right = null;
            this.btnSelectPath.Iconimage_right_Selected = null;
            this.btnSelectPath.Iconimage_Selected = null;
            this.btnSelectPath.IconMarginLeft = 0;
            this.btnSelectPath.IconMarginRight = 0;
            this.btnSelectPath.IconRightVisible = true;
            this.btnSelectPath.IconRightZoom = 0D;
            this.btnSelectPath.IconVisible = true;
            this.btnSelectPath.IconZoom = 80D;
            this.btnSelectPath.IsTab = false;
            this.btnSelectPath.Location = new System.Drawing.Point(532, 204);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectPath.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelectPath.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelectPath.selected = false;
            this.btnSelectPath.Size = new System.Drawing.Size(114, 29);
            this.btnSelectPath.TabIndex = 23;
            this.btnSelectPath.Text = "... ";
            this.btnSelectPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectPath.Textcolor = System.Drawing.Color.White;
            this.btnSelectPath.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtpath
            // 
            this.txtpath.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtpath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpath.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtpath.BorderThickness = 1;
            this.txtpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpath.isPassword = false;
            this.txtpath.Location = new System.Drawing.Point(155, 204);
            this.txtpath.Margin = new System.Windows.Forms.Padding(4);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(370, 29);
            this.txtpath.TabIndex = 22;
            this.txtpath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "الرجاء تحديد مسار النسخة الاحتياطية";
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label1);
            this.Name = "Backup";
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelectPath;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}