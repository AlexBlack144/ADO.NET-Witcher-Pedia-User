﻿namespace WindowsFormsWitcher.View
{
    partial class Form2
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
            this.listBox_Characters = new System.Windows.Forms.ListBox();
            this.label_Characters = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Characters
            // 
            this.listBox_Characters.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_Characters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Characters.Font = new System.Drawing.Font("Mason Chronicles", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Characters.FormattingEnabled = true;
            this.listBox_Characters.ItemHeight = 20;
            this.listBox_Characters.Location = new System.Drawing.Point(108, 134);
            this.listBox_Characters.Name = "listBox_Characters";
            this.listBox_Characters.Size = new System.Drawing.Size(187, 80);
            this.listBox_Characters.TabIndex = 6;
            this.listBox_Characters.SelectedIndexChanged += new System.EventHandler(this.listBox_Characters_SelectedIndexChanged);
            // 
            // label_Characters
            // 
            this.label_Characters.AutoSize = true;
            this.label_Characters.BackColor = System.Drawing.Color.Transparent;
            this.label_Characters.Font = new System.Drawing.Font("Mason Chronicles", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Characters.ForeColor = System.Drawing.Color.Brown;
            this.label_Characters.Location = new System.Drawing.Point(102, 98);
            this.label_Characters.Name = "label_Characters";
            this.label_Characters.Size = new System.Drawing.Size(154, 33);
            this.label_Characters.TabIndex = 5;
            this.label_Characters.Text = "Персонажи";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Mason Chronicles", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Brown;
            this.label_Title.Location = new System.Drawing.Point(12, 41);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(362, 39);
            this.label_Title.TabIndex = 7;
            this.label_Title.Text = "Ведьмак (Персонажи)";
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Back.Font = new System.Drawing.Font("Mason Chronicles", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Back.Location = new System.Drawing.Point(118, 233);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(138, 50);
            this.button_Back.TabIndex = 8;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsWitcher.Properties.Resources.background__3_;
            this.pictureBox1.Location = new System.Drawing.Point(151, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 61);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.listBox_Characters);
            this.Controls.Add(this.label_Characters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Characters;
        private System.Windows.Forms.Label label_Characters;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}