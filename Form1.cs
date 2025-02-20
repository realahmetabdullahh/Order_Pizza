using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Pizza_Order_Menu
{
    public partial class main : Form

    {

        
        public main()
        {
            InitializeComponent();
        }
       
       
        float GetSelectedSizePrice()
        {
            if (SizeRBSmall.Checked)
            {
                return Convert.ToSingle(SizeRBSmall.Tag);
            }
            else if (SizeRbMedium.Checked)
            {
                return Convert.ToSingle(SizeRbMedium.Tag);
            }
            else
            {

                return Convert.ToSingle(SizeRbBig.Tag);
            }



        }
        float CalculateToppingsPrice()
        {
            float TotalToppingsPrice = 0;
            if (checkToppingsOlives.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsOlives.Tag);
            }
            if (checkToppingsOnion.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsOnion.Tag);
            }
            if (checkToppingsPeppers.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsPeppers.Tag);
            }
            if (checkToppingsTomatoes.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsTomatoes.Tag);
            }
            if (checkToppingsMushroom.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsMushroom.Tag);

            }
            if (checkToppingsExtraChees.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(checkToppingsExtraChees.Tag);
            }
            return TotalToppingsPrice;
        }
        float GetSelectedCrutPrice()
        {
            if (CursorTypeRbThick.Checked)
            {
                return Convert.ToSingle(CursorTypeRbThick.Tag);

            }
            else
            {
                return Convert.ToSingle(CursorTypeRbThin.Tag);
            }
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }
        void UpdateTotalPrice()
        {
            TotalPriceAtSummary.Text = "$ " + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (SizeRBSmall.Checked)
            {
                SizeAtSummary.Text = "Small";
                return;
            }
            if(SizeRbMedium.Checked){
                SizeAtSummary.Text = "Medium";
                return;
            }
            if (SizeRbBig.Checked)
            {
                SizeAtSummary.Text = "Big";
            }
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (WhereToEatRbIn.Checked)
            {
                WhereToEatAtSummary.Text = "Eat In.";
                return;
            }

            if (WhereToEatRbOut.Checked)
            {
                WhereToEatAtSummary.Text = "Take Out.";
                return;
            }

        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (CursorTypeRbThin.Checked)
            {
                CrustTypeAtSummary.Text = "Thin Crust";
                return;
            }

            if (CursorTypeRbThick.Checked)
            {
                CrustTypeAtSummary.Text = "Thick Crust";
                return;
            }


        }
        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (checkToppingsExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (checkToppingsOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (checkToppingsMushroom.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (checkToppingsOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (checkToppingsTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (checkToppingsPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            ToppingsAtSummary.Text = sToppings;


        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }



        private void SizeAtSummary_TextChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

       
      
      

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Oeder", "Confirm",MessageBoxButtons.OKCancel) == DialogResult.OK) 
                {
                MessageBox.Show("Your Pizza Was Ordered","Succes",MessageBoxButtons.OK, MessageBoxIcon.Information);
                grSize.Enabled = false;
                grToppings.Enabled = false;
               grWhereToEat.Enabled= false;
                grCursorType.Enabled = false;  
                btnOrder.Enabled = false;

                }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure You Want To Reset!! ","Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Your Order Reset", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grSize.Enabled = true;
                grToppings.Enabled = true;
                grWhereToEat.Enabled = true;
                grCursorType.Enabled = true;
                btnOrder.Enabled = true;
                checkToppingsExtraChees.Checked = false;
                checkToppingsOnion.Checked = false;
                checkToppingsMushroom.Checked = false;
                checkToppingsOlives.Checked = false;
                checkToppingsTomatoes.Checked = false;
                checkToppingsPeppers.Checked = false;

                btnOrder.Enabled=true;
                CursorTypeRbThin.Checked = true;

                
                WhereToEatRbOut.Checked = true;


            }

        }

        private void SizeRBSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void SizeRbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void SizeRbBig_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void CursorTypeRbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void CursorTypeRbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void checkToppingsExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkToppingsMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkToppingsTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkToppingsOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkToppingsOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void checkToppingsPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void WhereToEatRbIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void WhereToEatRbOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
    }
}
