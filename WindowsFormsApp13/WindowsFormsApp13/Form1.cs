using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;
        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;
            int bitisuzaklıgı = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if(birinciatıngenisligi+pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı at kazandı !!!!!");
            }
            if (ikinciatıngenisligi + ikinciatsolauzaklık >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at kazandı !!!!!");
            }
            if (ucuncuatıngenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at kazandı !!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 93);
            pictureBox2.Location = new Point(12, 186);
            pictureBox3.Location = new Point(12, 281);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
