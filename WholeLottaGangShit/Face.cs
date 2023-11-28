using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WholeLottaGangShit
{
    public partial class Face : Form
    {
        public Face()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Run r = new Run();
            r.Show();
            Hide();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            Stay stay = new Stay();
            stay.Show();
            Hide();
        }
    }
}
