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
    public partial class Form2 : Form
    {
        public string selectNameChapter = "";
        public string selectNameChar = "";
        Controller1 controller1 = new Controller1();
        Form3 form3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            controller1.ShowCharactersForm2(listBox_Characters, selectNameChapter);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectNameChar = listBox_Characters.SelectedItem.ToString();
            controller1.ShowCharactersWimdow2(selectNameChar, form3);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
