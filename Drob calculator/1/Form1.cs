using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2;


namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region BT operations
        private void BTplus_Click(object sender, EventArgs e)
        {
            if(DrobChek(TB1.Text, TB2.Text) && DrobChek(TB3.Text, TB4.Text))
            {
                Drob d1 = DrobCreate(TB1, TB2);
                Drob d2 = DrobCreate(TB3, TB4);

                TB5.Text = (d1 + d2).ToString();
            }
            else
            {
                MessageBox.Show("Проверьте правильность дробей!");
            }
        }

        private void BTminus_Click(object sender, EventArgs e)
        {
            if (DrobChek(TB1.Text, TB2.Text) && DrobChek(TB3.Text, TB4.Text))
            {
                Drob d1 = DrobCreate(TB1, TB2);
                Drob d2 = DrobCreate(TB3, TB4);

                TB5.Text = (d1 - d2).ToString();
            }
            else
            {
                MessageBox.Show("Проверьте правильность дробей!");
            }
        }

        private void BTmult_Click(object sender, EventArgs e)
        {
            if (DrobChek(TB1.Text, TB2.Text) && DrobChek(TB3.Text, TB4.Text))
            {
                Drob d1 = DrobCreate(TB1, TB2);
                Drob d2 = DrobCreate(TB3, TB4);

                TB5.Text = (d1 * d2).ToString();
            }
            else
            {
                MessageBox.Show("Проверьте правильность дробей!");
            }
        }

        private void BTdel_Click(object sender, EventArgs e)
        {
            if (DrobChek(TB1.Text, TB2.Text) && DrobChek(TB3.Text, TB4.Text))
            {
                Drob d1 = DrobCreate(TB1, TB2);
                Drob d2 = DrobCreate(TB3, TB4);

                TB5.Text = (d1 / d2).ToString();
            }
            else
            {
                MessageBox.Show("Проверьте правильность дробей!");
            }
        }
        #endregion

        private Drob DrobCreate (TextBox chisl, TextBox znam)
        {
            Drob d = new Drob(Convert.ToInt32(chisl.Text), Convert.ToInt32(znam.Text));

            return d;
        }

        private bool DrobChek (string t1, string t2)
        {
            int i;
            bool chislok = Int32.TryParse(t1, out i);
            bool znamok = Int32.TryParse(t2, out i);
            if (znamok && i == 0) znamok = false;

            if (chislok && znamok)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
