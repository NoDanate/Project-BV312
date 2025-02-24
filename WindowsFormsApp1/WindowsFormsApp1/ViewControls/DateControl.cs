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
    public partial class DateControl : MyUserControl
    {
        private UserData userData;
        private MainController controller;
        public DateControl(UserData data, MainController ctrl)
        {
            InitializeComponent();
            userData = data;
            controller = ctrl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userData.SelectedDate = dateTimePicker1.Value;

            new Rules(userData, controller).CheckDate();
        }

    }
}
