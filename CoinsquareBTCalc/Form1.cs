using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinsquareBTCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //grab last sale price from coinsquare
            //keep in file for historical reasont
            //https://coinsquare.io/markets/bitcoin
            //<div class="etbCGx">13,869.63</div>
        }

        private void uxBTCcurrPrice_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(uxBTCcurrPrice.Text) != 0 )
            {
                var temp =  (1 / Convert.ToDouble(uxBTCcurrPrice.Text));
                uxPriceBTC.Text = temp.ToString("0.########");
            }
        }

        private void uxBTCquantity_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(uxBTCcurrPrice.Text) != 0 || uxBTCcurrPrice.Text != null)
            {
                var temp = Convert.ToDouble(uxBTCquantity.Text) / Convert.ToDouble(uxPriceBTC.Text);
                uxQuantityCAD.Text = temp.ToString("#.##");
            }
        }

        private void uxPrice_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(uxPrice.Text) != 0)
            {
                var temp = 1 / Convert.ToDouble(uxPrice.Text);
                uxPriceBTC2.Text = temp.ToString("0.########");
            }

        }

        private void uxQuantityAmount_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(uxQuantityAmount.Text) != 0)
            {
                var temp = Convert.ToDouble(uxPriceBTC2.Text) * Convert.ToDouble(uxQuantityAmount.Text);
                uxBTCaSale.Text = temp.ToString("#.########");
            }
        }

        //&& (Convert.ToDouble(uxBTCcurrPrice.Text) != 0)
    }
}
