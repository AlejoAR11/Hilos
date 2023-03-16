using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoTimer
{
    public partial class frmNoTimer : MaterialForm 

    {
        public frmNoTimer()
        {
            InitializeComponent();
        }

        private void frmNoTimer_Load(object sender, EventArgs e)
        {
            
        }

       private void Timer()
        {

           


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(new ThreadStart(Timer));
            hilo.Start();
        }
    }
}
