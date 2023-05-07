namespace WindowsFormsWitcher.View
{
    partial class Form3
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
            this.label_Name_char = new System.Windows.Forms.Label();
            this.pictureBox_char = new System.Windows.Forms.PictureBox();
            this.label_Characters = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_char)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name_char
            // 
            this.label_Name_char.AutoSize = true;
            this.label_Name_char.Font = new System.Drawing.Font("Mason Chronicles", 24F, System.Drawing.FontStyle.Bold);
            this.label_Name_char.Location = new System.Drawing.Point(197, 9);
            this.label_Name_char.Name = "label_Name_char";
            this.label_Name_char.Size = new System.Drawing.Size(116, 39);
            this.label_Name_char.TabIndex = 0;
            this.label_Name_char.Text = "label1";
            // 
            // pictureBox_char
            // 
            this.pictureBox_char.Location = new System.Drawing.Point(552, 9);
            this.pictureBox_char.Name = "pictureBox_char";
            this.pictureBox_char.Size = new System.Drawing.Size(254, 411);
            this.pictureBox_char.TabIndex = 1;
            this.pictureBox_char.TabStop = false;
            // 
            // label_Characters
            // 
            this.label_Characters.AutoSize = true;
            this.label_Characters.Font = new System.Drawing.Font("Mason Chronicles", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Characters.Location = new System.Drawing.Point(22, 60);
            this.label_Characters.Name = "label_Characters";
            this.label_Characters.Size = new System.Drawing.Size(170, 33);
            this.label_Characters.TabIndex = 6;
            this.label_Characters.Text = "Информация";
            // 
            // textBox_info
            // 
            this.textBox_info.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_info.Enabled = false;
            this.textBox_info.Font = new System.Drawing.Font("Mason Chronicles", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_info.Location = new System.Drawing.Point(28, 96);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(503, 324);
            this.textBox_info.TabIndex = 7;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Back.Location = new System.Drawing.Point(28, 9);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(97, 39);
            this.button_Back.TabIndex = 9;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsWitcher.Properties.Resources.background__3_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(818, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label_Characters);
            this.Controls.Add(this.pictureBox_char);
            this.Controls.Add(this.label_Name_char);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_char)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name_char;
        private System.Windows.Forms.PictureBox pictureBox_char;
        private System.Windows.Forms.Label label_Characters;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}