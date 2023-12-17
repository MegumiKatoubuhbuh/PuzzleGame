using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        static bool isPlaying;              //thong tin co dang choi khong
        static int movesMade;               //so lan di chuyen
        static PictureBox emptyPictureBox;  //tham chieu pictureBox dang trong
        static int emptyIndex;
        static List<Bitmap> images = new List<Bitmap>();    //danh sach cac anh
        static TimeSpan gameTime;     //thoi gian tu luc bat dau

        public Form1()
        {
            InitializeComponent();
            images.AddRange(new Bitmap[]{ Properties.Resources._0,
                                        Properties.Resources._1,Properties.Resources._2,
                                        Properties.Resources._3,Properties.Resources._4,
                                        Properties.Resources._5,Properties.Resources._6,
                                        Properties.Resources._7});
            emptyIndex = 8;
            movesMade = 0;
            isPlaying = false;

            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(pictureBox9);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isPlaying)                     //neu dang khong choi
            {
                emptyPictureBox = pictureBox9;
                Shuffle(images);
                movesMade = 0;
                gameTime = new TimeSpan(0, 0, 0);
                timer1.Start();
                isPlaying = true;
            }
            else                                   //neu dang trong qua trinh choi
            {
                if(MessageBox.Show("Ban chua hoan thanh, ban co muon choi lai khong","Thong bao",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    emptyPictureBox = pictureBox9;
                    Shuffle(images);
                    movesMade = 0;
                    label4.Text = movesMade.ToString();
                    gameTime = new TimeSpan(0, 0, 0);
                    timer1.Start();
                }
            }
        }

        

        private void pictureBoxClick(int index)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox selectPictureBox = sender as PictureBox;
            int index = Convert.ToInt32(selectPictureBox.Tag);

            if (IsAdj(selectPictureBox))
            {
                swapImage(emptyPictureBox, selectPictureBox);
                movesMade++;
                label4.Text = movesMade.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTime = gameTime.Add(new TimeSpan(0, 0, 1));
            label2.Text = gameTime.ToString(@"hh\:mm\:ss");
            if(isAllDone())
            {
                string thongbao = "Chuc mung ban da hoan thanh tro choi ";
                string diem = "\nSo nuoc di: " + movesMade.ToString();
                string thoiGian = "\nThoi gian hoan thanh: " + gameTime.ToString();
                MessageBox.Show(thongbao+diem+thoiGian,"Thong bao");
            }

        }

        public void Shuffle(List<Bitmap> images)
        {
            //thay doi thu tu lai nhu ban dau
            for(int i=0;i<8;i++)
            {
                (groupBox1.Controls[i] as PictureBox).Image = images[i];
            }
            pictureBox9.Image = null;
            //thuc hien xao tron anh 
            Random random = new Random();
            for(int i = 0;i<500;i++)
            {
                PictureBox randomPictureBox = groupBox1.Controls[random.Next(9)] as PictureBox;
                if (IsAdj(randomPictureBox))
                {
                    swapImage(emptyPictureBox, randomPictureBox);
                }
            }
        }

        //kiem tra co ke voi o trong khong
        private static bool IsAdj(PictureBox selectPictureBox)
        {
            int index = Convert.ToInt32(selectPictureBox.Tag);
            int emptyIndex = Convert.ToInt32(emptyPictureBox.Tag);
            int emptyX = emptyIndex / 3;
            int emptyY = emptyIndex % 3;

            int x = index / 3;
            int y = index % 3;

            if (x == emptyX && (y == emptyY - 1 || y == emptyY + 1))
                return true;

            if (y == emptyY && (x == emptyX - 1 || x == emptyX + 1))
                return true;

            return false;
        }

        private void swapImage(PictureBox pictureBoxEmpty, PictureBox selectPictureBox)
        {
            pictureBoxEmpty.Image = selectPictureBox.Image;
            selectPictureBox.Image = null;
            emptyPictureBox = selectPictureBox;

        }

        private bool isAllDone()
        {
            int i = 0;
            for(i = 0; i < 8; i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != images[i])
                    break;
            }
            if (i == 8)
            {
                timer1.Stop();
                isPlaying = false;
                return true;
            }
            else
                return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
