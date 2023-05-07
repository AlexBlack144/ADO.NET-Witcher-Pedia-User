using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WindowsFormsWitcher.Model;
using WindowsFormsWitcher.View;

namespace WindowsFormsWitcher.Controller
{
    internal class Controller1
    {
        public WebClient client = new WebClient();
        WitcherModel db = new WitcherModel();

        public void ShowChapters(ListBox listBox)
        {
            foreach (var item in db.Chapters)
            {
                listBox.Items.Add(item.Chapter_Name);
            }
        }

        public void ShowCharactersWimdow(string selectNameChapter, Form2 form)
        {
            form.selectNameChapter = selectNameChapter;
            form.ShowDialog();
           
        }

        public void ShowCharactersWimdow2(string selectNameChar, Form3 form)
        {
            form.selectNameChar = selectNameChar;
            form.ShowDialog();

        }

        public void ShowCharactersForm2(ListBox listBox, string selectNameChapter)
        {
            listBox.Items.Clear();
            foreach (var item in db.Chapters)
            {
                if (selectNameChapter == item.Chapter_Name)
                {
                    foreach (var item2 in db.Characters)
                    {
                        if (item2.Chapter_Id == item.Id)
                        {
                            listBox.Items.Add(item2.Name);
                        }

                    }
                }
            }

            
        }

        public void ShowCharactersForm3(PictureBox pictureBox, string selectNameChar, TextBox textBox, Label label)
        {
            try
            {
                foreach (var item in db.Characters)
                {
                    if (item.Name == selectNameChar)
                    {
                        label.Text = selectNameChar;
                        pictureBox.Image = GetVeserImg(item.Image);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        textBox.Text = $"{item.Description}" + Environment.NewLine + Environment.NewLine
                            + $"Пол: {item.Gender}" + Environment.NewLine + Environment.NewLine
                            + $"Раса: {item.Race}" + Environment.NewLine + Environment.NewLine
                            + $"Род занятий: {item.Occupation}" + Environment.NewLine + Environment.NewLine
                            + $"Принадлежность: {item.Affiliation}" + Environment.NewLine + Environment.NewLine
                            + $"Смерть: {item.Death}";
                    }
                }
            }
            catch { MessageBox.Show("Некорректная информация!"); }
        }

        public Image GetVeserImg(string path_pic)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(path_pic, "image.png");
            }

            return Image.FromFile("image.png");
        }

    }
}
