using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controls
{
    public partial class IsPolisControl : UserControl
    {
        private UserData userData;
        private MainController controller;
        public IsPolisControl(UserData data, MainController ctrl)
        {
            InitializeComponent();
            userData = data;
            controller = ctrl;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Вам не нужно получать полис.");
            controller.Reset();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            controller.ShowCitizenshipControl();
        }
    }
}
