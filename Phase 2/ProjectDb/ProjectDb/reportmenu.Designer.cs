
namespace ProjectDb
{
    partial class reportmenu
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
            this.SessionRep = new System.Windows.Forms.Button();
            this.photographerinfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SessionRep
            // 
            this.SessionRep.Location = new System.Drawing.Point(141, 234);
            this.SessionRep.Margin = new System.Windows.Forms.Padding(2);
            this.SessionRep.Name = "SessionRep";
            this.SessionRep.Size = new System.Drawing.Size(144, 48);
            this.SessionRep.TabIndex = 0;
            this.SessionRep.Text = "Session Report";
            this.SessionRep.UseVisualStyleBackColor = true;
            this.SessionRep.Click += new System.EventHandler(this.SessionRep_Click);
            // 
            // photographerinfo
            // 
            this.photographerinfo.Location = new System.Drawing.Point(141, 137);
            this.photographerinfo.Margin = new System.Windows.Forms.Padding(2);
            this.photographerinfo.Name = "photographerinfo";
            this.photographerinfo.Size = new System.Drawing.Size(144, 48);
            this.photographerinfo.TabIndex = 1;
            this.photographerinfo.Text = "Photographer info Report";
            this.photographerinfo.UseVisualStyleBackColor = true;
            this.photographerinfo.Click += new System.EventHandler(this.photographerinfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::ProjectDb.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(148, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reports";
            // 
            // reportmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photographerinfo);
            this.Controls.Add(this.SessionRep);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "reportmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportmenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reportmenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SessionRep;
        private System.Windows.Forms.Button photographerinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}