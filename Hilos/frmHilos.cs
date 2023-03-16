using MaterialSkin.Controls;
using System;

namespace Hilos
{
    public partial class frmHilos : MaterialForm
    {

        int cont1, cont2, cont3, valor;
        int x, y;
        bool fin1 = false, fin2 = false, fin3 = false;

        private void lblTimer1_Click(object sender, EventArgs e)
        {

        }

        private void tmrTimer3_Tick(object sender, EventArgs e)
        {
            x = lblTimer3.Location.X;
            y = lblTimer3.Location.Y;
            if (fin3 == false)
            {
                cont3++;
                if (cont3 <= 50)
                {
                    lblTimer3.Text = cont3.ToString();
                    lblTimer3.Location = new System.Drawing.Point(x + 3, y);
                }
                if (cont3 == 50) { fin3 = true; }
            }
            if (fin3 == true)
            {
                cont3--;
                if (cont3 >= 0)
                {
                    lblTimer3.Text = cont3.ToString();
                    lblTimer3.Location = new System.Drawing.Point(x - 3, y);

                }
                if (cont3 == 0) { fin3 = false; }
            }

        }

        public frmHilos()
        {
            InitializeComponent();
        }

        private void frmHilos_Load(object sender, EventArgs e)
        {





        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrTimer1.Enabled = true;
            tmrTimer2.Enabled = true;
            tmrTimer3.Enabled = true;



        }

        private void tmrTimer2_Tick(object sender, EventArgs e)
        {

            if (fin2 == false)
            {
                cont2++;
                if (cont2 <= 20) { lblTimer2.Text = cont2.ToString(); }

                else if (cont2 > 20)
                {
                    valor = cont1;
                    fin2 = true;
                }
            }

            if (fin2 == true)
            {
                valor--;
                cont2--;
                if (valor >= 0)
                {
                    lblTimer2.Text = cont2.ToString();
                }
                else if (valor < 0) { fin2 = false; }

            }





        }

        private void tmrTimer1_Tick(object sender, EventArgs e)
        {
            if (fin1 == false)
            {
                cont1++;
                if (cont1 <= 100) { lblTimer1.Text = cont1.ToString(); }

                else if (cont1 > 100) { fin1 = true; }
            }

            if (fin1 == true)
            {

                cont1--;
                if (cont1 >= 0)
                {
                    lblTimer1.Text = cont1.ToString();
                }
                else if (cont1 < 0) { fin1 = false; }

            }
        }

    }
}

