namespace WindowsFormsWitcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Title = new System.Windows.Forms.Label();
            this.listBox_chapters = new System.Windows.Forms.ListBox();
            this.label_Content = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Mason Chronicles", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Brown;
            this.label_Title.Location = new System.Drawing.Point(12, 32);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(282, 39);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Ведьмак (Главы)";
            // 
            // listBox_chapters
            // 
            this.listBox_chapters.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_chapters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_chapters.Font = new System.Drawing.Font("Mason Chronicles", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_chapters.FormattingEnabled = true;
            this.listBox_chapters.ItemHeight = 20;
            this.listBox_chapters.Location = new System.Drawing.Point(56, 129);
            this.listBox_chapters.Name = "listBox_chapters";
            this.listBox_chapters.Size = new System.Drawing.Size(187, 160);
            this.listBox_chapters.TabIndex = 1;
            this.listBox_chapters.Click += new System.EventHandler(this.listBox_chapters_Click);
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.BackColor = System.Drawing.Color.Transparent;
            this.label_Content.Font = new System.Drawing.Font("Mason Chronicles", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Content.ForeColor = System.Drawing.Color.Brown;
            this.label_Content.Location = new System.Drawing.Point(50, 93);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(167, 33);
            this.label_Content.TabIndex = 2;
            this.label_Content.Text = "Содержание";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsWitcher.Properties.Resources.background__3_;
            this.pictureBox1.Location = new System.Drawing.Point(105, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 61);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.listBox_chapters);
            this.Controls.Add(this.label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witcher\'s Handbook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ListBox listBox_chapters;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

