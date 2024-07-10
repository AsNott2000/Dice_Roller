using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class DiceRoller : Form
    {
        Random Dice = new Random();
        public DiceRoller()
        {
            InitializeComponent();
        }
        
        private void btn_roll(object sender, EventArgs e)
        {
            //birinci ve ikinci zarın aralığını tanımladık
            int DiceOne = Dice.Next(1, 7);
            int DiceTwo = Dice.Next(1, 7);

            //if de kullanılabilir fakat switch-case daha iyidir.
            //sizemode komutu ile atılan zarın boyutunu ayarladık
            //image location ile fotoğrafı bulduk
            switch (DiceOne)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\1.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "1";
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\2.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "2";
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "3";
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\4.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "4";
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\5.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "5";
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\6.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb1.Text = "6";
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\3.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            switch (DiceTwo)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\1.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "1";
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\2.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "2";
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\3.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "3";
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\4.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "4";
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\5.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "5";
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\6.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    tb2.Text = "6";
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\baris\OneDrive\Masaüstü\Dice Roller\İmages\3.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

                    
            }
            
            

        }
    }
}
