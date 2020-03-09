using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaczynamy
{
    public partial class Form1 : Form
    {
        Image obrazek;//globalna zmienna do przechywcenia obrazku z dysku
        public Form1()
        {
            InitializeComponent();
        }

        private void OtworzButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();//otwarcie okna dialogowoego i wybranie
            if(dr == DialogResult.OK)//sprawdzanie czy wybrano sprawny plik
            {
                obrazek = Image.FromFile(openFileDialog1.FileName);//przypisanie wybranego pliku do zmiennej
                pictureBox1.Image = obrazek;//wstawienie obrazka do picture boxa
            }
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)//sprawdzanie czy wybrano sprawny plik
            {
                if (obrazek != null)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3) == "jpg")
                    {
                        obrazek.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);

                    }
                    else if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3) == "png")
                    {
                        obrazek.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                    else (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3) == "bmp")
                    {
                        obrazek.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }
                        
                    
                } 
            }
        }
    }
}
