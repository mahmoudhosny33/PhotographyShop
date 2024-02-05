
namespace ProjectDb
{
    partial class mainForm
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
            this.photog_btn = new System.Windows.Forms.Button();
            this.session_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(100, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photography Shop";
            // 
            // photog_btn
            // 
            this.photog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photog_btn.Location = new System.Drawing.Point(121, 167);
            this.photog_btn.Name = "photog_btn";
            this.photog_btn.Size = new System.Drawing.Size(149, 33);
            this.photog_btn.TabIndex = 2;
            this.photog_btn.Text = "Photographers";
            this.photog_btn.UseVisualStyleBackColor = true;
            this.photog_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // session_btn
            // 
            this.session_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.session_btn.Location = new System.Drawing.Point(121, 219);
            this.session_btn.Name = "session_btn";
            this.session_btn.Size = new System.Drawing.Size(149, 33);
            this.session_btn.TabIndex = 3;
            this.session_btn.Text = "Sessions";
            this.session_btn.UseVisualStyleBackColor = true;
            this.session_btn.Click += new System.EventHandler(this.session_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectDb.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(78, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.session_btn);
            this.Controls.Add(this.photog_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button photog_btn;
        private System.Windows.Forms.Button session_btn;
        private System.Windows.Forms.Button button1;
    }
}