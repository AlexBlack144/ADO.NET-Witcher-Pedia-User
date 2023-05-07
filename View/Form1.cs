using System;
using WindowsFormsWitcher.Controller;
using System.Windows.Forms;
using WindowsFormsWitcher.View;
using System.IO;

namespace WindowsFormsWitcher
{
    public partial class Form1 : Form
    {
        Controller1 controller = new Controller1();
        public string selectNameChapter = "";
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.ShowChapters(listBox_chapters);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox_chapters_Click(object sender, EventArgs e)
        {
            selectNameChapter = listBox_chapters.SelectedItem.ToString();
            controller.ShowCharactersWimdow(selectNameChapter, form2);
        }
    }
}
