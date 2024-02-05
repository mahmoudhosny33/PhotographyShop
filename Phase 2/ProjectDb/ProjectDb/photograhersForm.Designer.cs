
namespace ProjectDb
{
    partial class photograhersForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_name = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(152, 188);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(199, 20);
            this.txt_address.TabIndex = 5;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(152, 149);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(199, 20);
            this.txt_salary.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone number";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(152, 232);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(199, 20);
            this.txt_phone.TabIndex = 9;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(187, 459);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(127, 23);
            this.submit_btn.TabIndex = 10;
            this.submit_btn.Text = "Insert";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(152, 273);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(146, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Photographers";
            // 
            // combo_name
            // 
            this.combo_name.FormattingEnabled = true;
            this.combo_name.Location = new System.Drawing.Point(152, 105);
            this.combo_name.Name = "combo_name";
            this.combo_name.Size = new System.Drawing.Size(199, 21);
            this.combo_name.TabIndex = 13;
            this.combo_name.SelectedIndexChanged += new System.EventHandler(this.combo_name_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(329, 459);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(127, 23);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(43, 459);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(127, 23);
            this.Update_btn.TabIndex = 15;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(152, 67);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(199, 20);
            this.txt_ID.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Photographer ID";
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(380, 64);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(98, 23);
            this.show_btn.TabIndex = 18;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::ProjectDb.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // photograhersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.combo_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "photograhersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photographers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_name;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

