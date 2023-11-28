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
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            Turn turn = new Turn();
            turn.Show();
            Hide();
        }
    }
}
