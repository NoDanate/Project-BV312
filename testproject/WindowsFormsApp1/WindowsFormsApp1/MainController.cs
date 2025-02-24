using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;
using WindowsFormsApp1.ViewControls;

namespace WindowsFormsApp1
{
    public class MainController
    {
        private Form1 mainForm;
        private UserData userData;
        private Rules rules;

        public MainController(Form1 form)
        {
            mainForm = form;
            userData = new UserData();
            rules = new Rules(userData, this);
        }

        public void StartMedicalScenario()
        {
            ShowDateControl();
        }

        public void StartInsuranceScenario()
        {
            ShowIsPolisControl();
        }

        public void ShowIsPolisControl() 
        {
            var isPolisControl = new IsPolisControl(userData, this);
            SwitchToControl(isPolisControl);
        }

        public void ShowDateControl()
        {
            var dateControl = new DateControl(userData, this);
            SwitchToControl(dateControl);
        }

        public void ShowPurposeControl()
        {
            var purposeControl = new PurposeControl(userData, this);
            SwitchToControl(purposeControl);
        }

        public void ShowOrganizationControl()
        {
            var organizationControl = new OrganizationControl(userData, this, "медицинское освидетельствование");
            SwitchToControl(organizationControl);
        }

        public void ShowCitizenshipControl()
        {
            var citizenshipControl = new CitizenshipControl(userData, this);
            SwitchToControl(citizenshipControl);
        }

        public void ShowInsuranceOrganizationControl()
        {
            var organizationControl = new OrganizationControl(userData, this, "страховая компания");
            SwitchToControl(organizationControl);
        }

        public void SwitchToControl(UserControl control)
        {
            mainForm.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainForm.Controls.Add(control);
        }

        public void Reset()
        {
            mainForm.ResetToMainScreen();

            //userData = new UserData();
        }
    }
}
