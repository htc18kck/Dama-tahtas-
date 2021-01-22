using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];//bu bir çoklu dizi
            int top = 0;// yükseklik
            int left = 0;//sol
            for (int i = 0; i <=buttons.GetUpperBound(0); i++)
                //satır için for
            {
                for (int j = 0; j <=buttons.GetUpperBound(1); j++)
                //sütun için for
                {
                    buttons[i, j] = new Button();//oluşturulacak her buton yeni butondur.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;// başlangıçtan uzaklığı soldan
                    buttons[i, j].Top = top;//başlangıçtan uzaklığı yukardan

                    left += 50; //başlangıçtan uzaklığı artra artıra gider.
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);//Butonu ekledik.
                   

                }
                top += 50;//yukardan uzaklığı artıra artıra gider.
                left = 0;
            }
           
        }
    }
}
