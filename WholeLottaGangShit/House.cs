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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoIn go = new GoIn();
            go.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeepRunning run = new KeepRunning();
            run.Show();
            Hide();
        }
    }
}
