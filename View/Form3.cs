using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWitcher.Controller;

namespace WindowsFormsWitcher.View
{
    public partial class Form3 : Form
    {
        public string selectNameChar = "";
        Controller1 controller1 = new Controller1();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            controller1.ShowCharactersForm3(this.pictureBox_char, selectNameChar, textBox_info, label_Name_char);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           pictureBox_char.Image.Dispose();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
