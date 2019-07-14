namespace Query_Ticket.PL
{
    partial class Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnSelectPath = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "الرجاء تحديد مسار النسخة الاحتياطية";
            // 
            // txtPath
            // 
            this.txtPath.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPath.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPath.BorderThickness = 1;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.isPassword = false;
            this.txtPath.Location = new System.Drawing.Point(214, 196);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(370, 29);
            this.txtPath.TabIndex = 18;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSelectPath.Location = new System.Drawing.Point(591, 196);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelectPath.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelectPath.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelectPath.selected = false;
            this.btnSelectPath.Size = new System.Drawing.Size(114, 29);
            this.btnSelectPath.TabIndex = 19;
            this.btnSelectPath.Text = "... ";
            this.btnSelectPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectPath.Textcolor = System.Drawing.Color.White;
            this.btnSelectPath.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.BorderRadius = 0;
            this.btnRestore.ButtonText = "استعادة النسخة الاحتياطية";
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestore.Iconimage")));
            this.btnRestore.Iconimage_right = null;
            this.btnRestore.Iconimage_right_Selected = null;
            this.btnRestore.Iconimage_Selected = null;
            this.btnRestore.IconMarginLeft = 0;
            this.btnRestore.IconMarginRight = 0;
            this.btnRestore.IconRightVisible = true;
            this.btnRestore.IconRightZoom = 0D;
            this.btnRestore.IconVisible = true;
            this.btnRestore.IconZoom = 60D;
            this.btnRestore.IsTab = false;
            this.btnRestore.Location = new System.Drawing.Point(214, 246);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRestore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestore.selected = false;
            this.btnRestore.Size = new System.Drawing.Size(370, 34);
            this.btnRestore.TabIndex = 20;
            this.btnRestore.Text = "استعادة النسخة الاحتياطية";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestore.Textcolor = System.Drawing.Color.White;
            this.btnRestore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label1);
            this.Name = "Restore";
            this.Text = "Restore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPath;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelectPath;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}