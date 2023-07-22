using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro01
{
    public partial class Form1 : Form
    {
        public int cost = 0;
        public int count = 0;
        public List<string> list = new List<string>();
        public StringBuilder sb = new StringBuilder();
        public string menu = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            cost += 5000;
            list.Add("불고기버거");
            foreach (var i in list)
            {
                sb.AppendLine(i);
            }

            Text_cart.Text += "불고기버거 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count++;
            cost += 5000;
            list.Add("치즈버거");

            foreach (var i in list)
            {
                sb.AppendLine(i);
            }
            Text_cart.Text += "치즈버거 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count++;
            cost += 6000;
            list.Add("베이컨토마토디럭스버거");

            foreach (var i in list)
            {
                sb.AppendLine(i);
            }
            Text_cart.Text += "베토디버거 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            count++;
            cost += 6000;
            list.Add("슈비버거");
            foreach (var i in list)
            {
                sb.AppendLine(i);
            }
            Text_cart.Text += "슈비버거 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();
        }

        private void bt_suc_Click(object sender, EventArgs e)
        {

        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            cost = 0;
            list.Clear();
            count = 0;
            text_money.Text = null;
            Text_cart.Text = null;
            label11.Text = null;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            count++;
            cost += 2000;
            list.Add("콜라");

            Text_cart.Text += "콜라 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            count++;
            cost += 2000;
            list.Add("사이다");
            Text_cart.Text += "사이다 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            count++;
            cost += 3000;
            list.Add("감자튀김");
            Text_cart.Text += "감자튀김 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            count++;
            cost += 3000;
            list.Add("치즈스틱");
            Text_cart.Text += "치즈스틱 \n";
            text_money.Text = cost.ToString();
            label11.Text = count.ToString();
        }
    }
}
