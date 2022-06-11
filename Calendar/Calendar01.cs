using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar01 : Form
    {
        public Calendar01()
        {
            InitializeComponent();
        }
        private void hide_btn_Click(object sender, EventArgs e)
        {
            group01.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            group01.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_1.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
