using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pro01
{
    public partial class mainForm : Form
    {
        public string menu = "";
        public string str = "";
        public int menu_cost = 0;
        public int Count = 0;

        public int total_cost = 0;
        
        public int friesCount = 0;
        public int stickCount = 0;
        public int coleCount = 0;
        public int nugCount = 0;
        public int cokeCount = 0;
        public int zeroCount = 0;
        public int sprCount = 0;
        public int cofCount = 0;
        public int icedCount = 0;
        public int shakeCount = 0;
        public int softCount = 0;
        public int sundaeCount = 0;
        public int beefCount = 0;
        public int vanilaCount = 0;
        public int cheeseCount = 0;
        public int stick2Count = 0;
        public int bulsolCount = 0;
        public int macsolCount = 0;
        public int bacsolCount = 0;
        public int quasolCount = 0;
        public int sol1955Count = 0;
        public int sangsolCount = 0;
        public int bulsetCount = 0;
        public int macsetCount = 0;
        public int quasetCount = 0;
        public int set1955Count = 0;
        public int sangsetCount = 0;
        public int bacsetCount = 0;
    

        // 시작 시 초기화
        public mainForm()
        {
            InitializeComponent();

            panel1.Size = new Size(640, 1075);
            panelNext.Size = new Size(640, 1075);
            panelPay.Size = new Size(640, 1075);
            panelSuc.Size = new Size(640, 1075);

            panelHappy.Size = new Size(478, 603);
            panelBev.Size = new Size(478, 603);
            panelSide.Size = new Size(478, 603);
            panelSig.Size = new Size(478, 603);

            panel1.Visible = true;
            panelSig.Visible = false;
            panelBev.Visible = false;
            panelSide.Visible = false;
            panelNext.Visible = false;
            panelHappy.Visible = false;
            panelPay.Visible = false;
            panelSuc.Visible = false;


            lbSelected.Text = "";
            textCost.Text = "";
            lbCount.Text = "";
            listOrder.Items.Clear();

            panelSig.Location = new Point(146, 160);
            panelBev.Location = new Point(146, 160);
            panelSide.Location = new Point(146, 160);
            panelHappy.Location = new Point(146, 160);

            panel1.Location = new Point(0, 0);
            panelNext.Location = new Point(0, 0);
            panelPay.Location = new Point(0, 0);
            panelSuc.Location = new Point(0, 0);

            listOrder.Items.Clear();
            listOrder.View = View.Details;


        }

        //메뉴바 선택

        private void picRec_Click(object sender, EventArgs e)
        {
            panelBev.Visible = false;
            panelSide.Visible = false;
            panelSig.Visible = false;
            panelHappy.Visible = true;
            lbSelected.Text = lbRec.Text;
            lbRec.ForeColor = Color.Blue;
        }

        private void picSig_Click(object sender, EventArgs e)
        {
            panelHappy.Visible = false;
            panelSide.Visible = false;
            panelBev.Visible = false;
            panelSig.Visible = true;
            lbSelected.Text = lbSig.Text;
            lbSig.ForeColor = Color.Blue;

        }

        private void picSide_Click(object sender, EventArgs e)
        {
            panelHappy.Visible = false;
            panelSig.Visible = false;
            panelBev.Visible = false;
            panelSide.Visible = true;
            lbSelected.Text = lbSide.Text;
            lbSide.ForeColor = Color.Blue;
        }

        private void picBev_Click(object sender, EventArgs e)
        {
            panelHappy.Visible = false;
            panelSig.Visible = false;
            panelSide.Visible = false;
            panelBev.Visible = true;
            lbSelected.Text = lbBev.Text;
            lbBev.ForeColor = Color.Blue;
        }


        // 시그니처 버거 - 햄버거 선택

        private void picBulgogi_Click(object sender, EventArgs e)
        {
            menu = lbBulgogi.Text;
            menu_cost = int.Parse(costBul.Text);
            picSelected.Image = picBulgogi.Image;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        private void picQuat_Click(object sender, EventArgs e)
        {
            menu = lbQuat.Text;
            menu_cost = int.Parse(costQuat.Text);
            picSelected.Image = picQuat.Image;
            lbSelect.Text = menu;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        private void picBacon_Click(object sender, EventArgs e)
        {
            menu = lbBacon.Text;
            menu_cost = int.Parse(costBacon.Text);
            picSelected.Image = picBacon.Image;
            lbSelect.Text = menu;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        private void picMac_Click(object sender, EventArgs e)
        {
            menu = lbMac.Text;
            menu_cost = int.Parse(costMac.Text);
            picSelected.Image = picMac.Image;
            lbSelect.Text = menu;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        private void picSang_Click(object sender, EventArgs e)
        {
            menu = lbSang.Text;
            menu_cost = int.Parse(costSang.Text);
            picSelected.Image = picSang.Image;
            lbSelect.Text = menu;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        private void pic1955_Click(object sender, EventArgs e)
        {
            menu = lb1955.Text;
            menu_cost = int.Parse(cost1955.Text);
            picSelected.Image = pic1955.Image;
            lbSelect.Text = menu;
            picSelected.SizeMode = PictureBoxSizeMode.StretchImage;
            lbSelect.Text = menu;
            lbCostSel.Text = menu_cost.ToString() + "원";
            total_cost += menu_cost;

            panel1.Visible = false;
            panelNext.Visible = true;
        }

        // 사이드 선택

        private void picFries_Click(object sender, EventArgs e)
        {
            menu = lbFries.Text;
            menu_cost = Convert.ToInt32(costFries.Text);

            friesCount++;
            Count++;
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            lbCount.Text = Count.ToString();

            if (friesCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, friesCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, friesCount.ToString() }));
            }
        }

        private void picStick_Click(object sender, EventArgs e)
        {

            menu = lbStick.Text;
            menu_cost = int.Parse(costStick.Text);

            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            stickCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (stickCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, stickCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, stickCount.ToString() }));
            }
        }

        private void picNugget_Click(object sender, EventArgs e)
        {
            menu = lbNug.Text;
            menu_cost = int.Parse(costNug.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            nugCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (nugCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, nugCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, nugCount.ToString() }));
            }
        }

        private void picCole_Click(object sender, EventArgs e)
        {
            menu = lbCole.Text;
            menu_cost = int.Parse(costCole.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            coleCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (coleCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, coleCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, coleCount.ToString() }));
            }
        }

        private void picSoft_Click(object sender, EventArgs e)
        {
            menu = lbSoft.Text;
            menu_cost = int.Parse(costSoft.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            softCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (softCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, softCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, softCount.ToString() }));
            }
        }

        private void picSundae_Click(object sender, EventArgs e)
        {
            menu = lbSundae.Text;
            menu_cost = int.Parse(costSundae.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            sundaeCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (sundaeCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, sundaeCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, sundaeCount.ToString() }));
            }
        }

        // 음료 선택

        private void picCoke_Click(object sender, EventArgs e)
        {
            menu = lbCoke.Text;
            menu_cost = int.Parse(costCoke.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            cokeCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (cokeCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cokeCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cokeCount.ToString() }));
            }
        }

        private void picZero_Click(object sender, EventArgs e)
        {
            menu = lbZero.Text;
            menu_cost = int.Parse(costZero.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            zeroCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (zeroCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, zeroCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, zeroCount.ToString() }));
            }
        }

        private void picSpr_Click(object sender, EventArgs e)
        {
            menu = lbSpr.Text;
            menu_cost = int.Parse(costSpr.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            sprCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (sprCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, sprCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, sprCount.ToString() }));
            }
        }

        private void picShake_Click(object sender, EventArgs e)
        {
            menu = lbShake.Text;
            menu_cost = int.Parse(costShake.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            shakeCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (shakeCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, shakeCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, shakeCount.ToString() }));
            }
        }

        private void picIceCof_Click(object sender, EventArgs e)
        {
            menu = lbIceCof.Text;
            menu_cost = int.Parse(costIceCof.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            icedCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (icedCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, icedCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, icedCount.ToString() }));
            }
        }

        private void picCof_Click(object sender, EventArgs e)
        {
            menu = lbCof.Text;
            menu_cost = int.Parse(costCof.Text);
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            cofCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (cofCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cofCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cofCount.ToString() }));
            }
        }

        private void picBeef_Click(object sender, EventArgs e)
        {
            menu = lbBeef.Text;
            menu_cost = 2500;
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            beefCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (beefCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, beefCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, beefCount.ToString() }));
            }
        }

        private void picVanila_Click(object sender, EventArgs e)
        {
            menu = lbVanila.Text;
            menu_cost = 2500;
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            vanilaCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (vanilaCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, vanilaCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, vanilaCount.ToString() }));
            }
        }

        private void picCheese_Click(object sender, EventArgs e)
        {
            menu = lbCheese.Text;
            menu_cost = 2000;
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            cheeseCount++;
            Count++;
            lbCount.Text = Count.ToString();

            if (cheeseCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cheeseCount.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, cheeseCount.ToString() }));
            }
        }

        private void picStick2_Click(object sender, EventArgs e)
        {
            menu = lbStick2.Text;
            menu_cost = 2500;
            total_cost += menu_cost;
            textCost.Text = total_cost.ToString();
            stick2Count++;
            Count++;
            lbCount.Text = Count.ToString();

            if (stickCount > 1)
            {

                int index = listOrder.FindItemWithText(menu).Index;
                int iCut = listOrder.FindItemWithText(menu, true, index, false).Index;
                //list_View.Items[iCut].Selected = true;
                listOrder.Items.RemoveAt(iCut);
                listOrder.Items.Add(new ListViewItem(new string[] { menu, stick2Count.ToString() }));

            }
            else
            {
                listOrder.Items.Add(new ListViewItem(new string[] { menu, stick2Count.ToString() }));
            }
        }

        // 돌아가기 버튼
        private void btnBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelNext.Visible = false;
            total_cost += menu_cost;

            radioCoke.Checked = false;
            radioZero.Checked = false;
            radioAme.Checked = false;
            radioIced.Checked = false;
            radioSpr.Checked = false;
            radioShake.Checked = false;
            radioFries.Checked = false;
            radioCole.Checked = false;
            radioNugget.Checked = false;
            radioStick.Checked = false;

        }

        // 햄버거 - 단품 선택 
        private void btSolo_Click(object sender, EventArgs e)
        {

            Count++;
            textCost.Text = total_cost.ToString();
            lbCount.Text = Count.ToString();

            // 불고기버거 단품
            if (menu == lbBulgogi.Text)
            {
                bulsolCount++;

                string str = menu + " 단품";

                if (bulsolCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bulsolCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bulsolCount.ToString() }));
                }


            }

            // 쿼터파운드 단품
            if (menu == lbQuat.Text)
            {
                quasolCount++;

                string str = menu + " 단품";

                if (quasolCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, quasolCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, quasolCount.ToString() }));
                }
            }

            // 빅맥 단품
            if (menu == lbMac.Text)
            {
                macsolCount++;

                string str = menu + " 단품";

                if (macsolCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, macsolCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, macsolCount.ToString() }));
                }

            }

            // 1955 단품
            if (menu == lb1955.Text)
            {
                sol1955Count++;

                string str = menu + " 단품";

                if (sol1955Count > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sol1955Count.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sol1955Count.ToString() }));
                }
            }

            // 베토디 단품
            if (menu == lbBacon.Text)
            {
                bacsolCount++;

                string str = menu + " 단품";

                if (bacsolCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bacsolCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bacsolCount.ToString() }));
                }
            }

            // 상하이 단품
            if (menu == lbSang.Text)
            {
                sangsolCount++;

                string str = menu + " 단품";

                if (sangsolCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sangsolCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sangsolCount.ToString() }));
                }
            }

            panel1.Visible = true;
            panelNext.Visible = false;
        }

        // 햄버거 - 세트 선택
        private void btSet_Click(object sender, EventArgs e)
        {

            if ((radioCoke.Checked == false && radioZero.Checked == false && radioSpr.Checked == false
                && radioShake.Checked == false && radioIced.Checked == false && radioAme.Checked == false) ||
                (radioFries.Checked == false && radioStick.Checked == false && radioNugget.Checked == false
                && radioCole.Checked == false))
            {
                MessageBox.Show("항목을 선택하세요 ");
                return;
            }

            string bevStr = "";
            if (radioCoke.Checked)
            {
                bevStr = "코카콜라";
                lbSelect.Text += "세트 (" + bevStr;
            }
            if (radioZero.Checked)
            {
                bevStr = "코카콜라 제로";
                lbSelect.Text += "세트 (" + bevStr;
            }
            if (radioSpr.Checked)
            {
                bevStr = "스프라이트";
                lbSelect.Text += "세트 (" + bevStr;
            }
            if (radioShake.Checked)
            {
                bevStr = "바닐라 쉐이크";
                lbSelect.Text += "세트 (" + bevStr;
            }
            if (radioIced.Checked)
            {
                bevStr = "아이스 아메리카노";
                lbSelect.Text += "세트 (" + bevStr;
            }
            if (radioAme.Checked)
            {
                bevStr = "아메리카노";
                lbSelect.Text += "세트 (" + bevStr;
            }


            string sideStr = "";

            if (radioFries.Checked)
            {
                sideStr = "후렌치 후라이";
                lbSelect.Text += "/" + sideStr + ")";
            }
            if (radioCole.Checked)
            {
                sideStr = "코울슬로";
                lbSelect.Text += "/" + sideStr + ")";
            }
            if (radioNugget.Checked)
            {
                sideStr = "맥너겟";
                lbSelect.Text += "/" + sideStr + ")";
            }
            if (radioStick.Checked)
            {
                sideStr = "골든 모짜렐라 치즈스틱";
                lbSelect.Text += "/" + sideStr + ")";
            }


            total_cost += 3000;
            Count++;


            textCost.Text = total_cost.ToString();
            lbCount.Text = Count.ToString();


            if (menu == lbBulgogi.Text)
            {
                str = menu + " 세트 ";

                bulsetCount++;
                if (bulsetCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bulsetCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bulsetCount.ToString() }));
                }
            }
            if (menu == lbBacon.Text)
            {
                str = menu + " 세트 ";
                bacsetCount++;
                if (bacsetCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bacsetCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, bacsetCount.ToString() }));
                }
            }
            if (menu == lb1955.Text)
            {
                str = menu + " 세트 ";
                set1955Count++;
                if (set1955Count > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, set1955Count.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, set1955Count.ToString() }));
                }
            }
            if (menu == lbMac.Text)
            {
                str = menu + " 세트 ";
                macsetCount++;
                if (macsetCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, macsetCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, macsetCount.ToString() }));
                }
            }
            if (menu == lbSang.Text)
            {
                str = menu + " 세트 ";
                sangsetCount++;
                if (sangsetCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sangsetCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, sangsetCount.ToString() }));
                }
            }
            if (menu == lbQuat.Text)
            {
                str = menu + " 세트 ";
                quasetCount++;
                if (quasetCount > 1)
                {

                    int index = listOrder.FindItemWithText(str).Index;
                    int iCut = listOrder.FindItemWithText(str, true, index, false).Index;
                    //list_View.Items[iCut].Selected = true;
                    listOrder.Items.RemoveAt(iCut);
                    listOrder.Items.Add(new ListViewItem(new string[] { str, quasetCount.ToString() }));

                }
                else
                {
                    listOrder.Items.Add(new ListViewItem(new string[] { str, quasetCount.ToString() }));
                }
            }
            panelNext.Visible = false;
            panel1.Visible = true;
            radioCoke.Checked = false;
            radioZero.Checked = false;
            radioAme.Checked = false;
            radioIced.Checked = false;
            radioSpr.Checked = false;
            radioShake.Checked = false;
            radioFries.Checked = false;
            radioCole.Checked = false;
            radioNugget.Checked = false;
            radioStick.Checked = false;


        }

        // 다음 주문확인창 넘어가기

        private void picPay_Click(object sender, EventArgs e)
        {
            panelPay.Visible = true;
            lbTotalCost.Text = total_cost.ToString();

        }

        private void picSelClear_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listOrder.FocusedItem.Index;
                listOrder.Items.RemoveAt(index);
                Count--;
                lbCount.Text = Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("장바구니 리스트 확인 ");
            }
        }

        // 전체 초기화
        private void picClear_Click(object sender, EventArgs e)
        {
            textCost.Text = "";
            lbCount.Text = "";

            Count = 0;
            menu = "";
            menu_cost = 0;
            total_cost = 0;
            listOrder.Items.Clear();

            friesCount = 0;
            stickCount = 0;
            coleCount = 0;
            nugCount = 0;
            cokeCount = 0;
            zeroCount = 0;
        sprCount = 0;
          cofCount = 0;
        icedCount = 0;
        shakeCount = 0;
        softCount = 0;
        sundaeCount = 0;
        beefCount = 0;
        vanilaCount = 0;
        cheeseCount = 0;
        stick2Count = 0;
        bulsolCount = 0;
        macsolCount = 0;
        bacsolCount = 0;
        quasolCount = 0;
        sol1955Count = 0;
        sangsolCount = 0;
        bulsetCount = 0;
        macsetCount = 0;
        quasetCount = 0;
        set1955Count = 0;
        sangsetCount = 0;
        bacsetCount = 0;


    }

        private void picBack3_Click(object sender, EventArgs e)
        {
            panelPay.Visible = false;

            textMember.Text = "";
            lbMembership.Text = "";
            radioPoint.Checked = false;
            radioNoId.Checked = false;
            textPoint.Text = "";
            lbPoint.Text = "";


        }

        private void btmembership_Click(object sender, EventArgs e)
        {

            if (listBox1.Text == "")
            {
                MessageBox.Show("제휴할인을 선택해주세요");
                return;
            }
            if (listBox1.Text == "없음")
            {
                lbMembership.Text = "할인 해당안됨";
                return;
            }
            else
            {
                int a = total_cost / 1000;
                int b = total_cost - a * 100;
                //double s = (double)total_cost * (0.9);
                //s = s / 100;
                //s = s * 100;
                //total_cost = (int)s;
                lbMembership.Text = $"{listBox1.Text} 할인되어 총 {b}원입니다.";
                total_cost = b;
            }
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            if (radioNoId.Checked)
            {
                lbPoint.Text = "포인트 해당안됨";
            }
            if (radioPoint.Checked)
            {
                if (textPoint.Text.Length != 11)
                {
                    MessageBox.Show("번호를 다시 입력하세요.");
                }
                else
                {
                    int a = int.Parse(textPoint.Text);
                    int num = a % 10000;
                    double po = total_cost * (0.1);
                    lbPoint.Text = "뒷 번호 " + num.ToString() + "로 " + po + "포인트 적립되었습니다. ";
                }
            }
        }

        // 초기화
        private void picFirstPanel_Click(object sender, EventArgs e)
        {
            panelPay.Visible = false;
            panel1.Visible = true;

            textMember.Text = "";
            lbMembership.Text = "";
            radioPoint.Checked = false;
            radioNoId.Checked = false;
            textPoint.Text = "";
            lbPoint.Text = "";

            lbSelected.Text = "";
            textCost.Text = "";
            lbCount.Text = "";
            listOrder.Items.Clear();

            total_cost = 0;
            Count = 0;

            friesCount = 0;
            stickCount = 0;
            coleCount = 0;
            nugCount = 0;
            cokeCount = 0;
            zeroCount = 0;
            sprCount = 0;
            cofCount = 0;
            icedCount = 0;
            shakeCount = 0;
            softCount = 0;
            sundaeCount = 0;
            beefCount = 0;
            vanilaCount = 0;
            cheeseCount = 0;
            stick2Count = 0;
            bulsolCount = 0;
            macsolCount = 0;
            bacsolCount = 0;
            quasolCount = 0;
            sol1955Count = 0;
            sangsolCount = 0;
            bulsetCount = 0;
            macsetCount = 0;
            quasetCount = 0;
            set1955Count = 0;
            sangsetCount = 0;
            bacsetCount = 0;

        }

        private void picEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(total_cost.ToString() + "원 결제 되었습니다.");

            panelSuc.Visible = true;
            panelPay.Visible = false;
            Random random = new Random();
            int a = random.Next(1000, 10000);
            lbdaegi.Text = a.ToString();

        }

        private void panelSuc_Click(object sender, EventArgs e)
        {
            panelSuc.Visible = false;
            panelPay.Visible = false;
            panel1.Visible = true;

            textMember.Text = "";
            lbMembership.Text = "";
            radioPoint.Checked = false;
            radioNoId.Checked = false;
            textPoint.Text = "";
            lbPoint.Text = "";

            lbSelected.Text = "";
            textCost.Text = "";
            lbCount.Text = "";
            listOrder.Items.Clear();

            total_cost = 0;
            Count = 0;
        }
    }
}
