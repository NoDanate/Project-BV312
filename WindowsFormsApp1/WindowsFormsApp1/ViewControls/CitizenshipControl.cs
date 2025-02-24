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
    public partial class CitizenshipControl : UserControl
    {
        private UserData userData;
        private MainController controller;

        public CitizenshipControl(UserData data, MainController ctrl)
        {
            InitializeComponent();
            userData = data;
            controller = ctrl;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            userData.Citizenship = comboBox1.SelectedItem.ToString();
            new Rules(userData, controller).CheckCitizenship();
            //if ()
            //{
            //    //controller.ShowInsuranceOrganizationControl();
            //}
        }
    }
}
