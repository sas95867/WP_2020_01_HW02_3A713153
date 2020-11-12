using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713153.Properties;

namespace WP_2020_01_HW02_3A713153
{

    public partial class frmGame : Form
    {
        List<Image> list = new List<Image>();
        poker p = null;
        List<int> poker;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            p = new poker();
            poker = p.GetPoker(52);
            for (int i = 1; i < 53; i++)
            {
                //string resourceName = i.ToString("2");
                string resourceNum = i.ToString("D3");
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceNum);
                list.Add(bmp);
            }



        }

        int a = 0;
        private void btnGO_Click(object sender, EventArgs e)
        {
            if (a < 52)
            {

                picResult.Image = list[poker[a]];

                a = a + 1;
            }
            if (a == 52)
            {
                MessageBox.Show("請洗牌", "沒牌拉");
            }

        }




        private void btn2_Click(object sender, EventArgs e)
        {
            p = new poker();
            poker = p.GetPoker(52);
            a = 0;

        }
    }
}
