using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PurposeControl : MyUserControl
    {
        private UserData userData;
        private MainController controller;

        public PurposeControl(UserData data, MainController ctrl)
        {
            InitializeComponent();
            userData = data;
            controller = ctrl;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            userData.Purpose = comboBox1.SelectedItem.ToString();

            new Rules(userData, controller).CheckPurpose();
        }
    }
}
