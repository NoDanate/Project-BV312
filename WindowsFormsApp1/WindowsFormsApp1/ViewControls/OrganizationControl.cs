using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.ViewControls
{
    public partial class OrganizationControl : UserControl
    {
        public OrganizationControl(UserData data, MainController ctrl, string organizationType)
        {
            InitializeComponent();

            if(organizationType == "медицинское освидетельствование")
            {
                Label lblMessage = new Label
                {

                    Text = $"Вы направлены в медицинскую организацию. Срок истечения направления - {new Rules(data, ctrl).ReturnDateForOrg()}",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                Controls.Add(lblMessage);
            }
            else
            {
                Label lblMessage = new Label
                {

                    Text = $"Вы направлены в страховую компанию.",
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                Controls.Add(lblMessage);
            }

            Button button = new Button
            {
                Text = "Вернуться в главное меню",
                Location = new Point(330, 330)
            };

            button.Click += (s, e) => ctrl.Reset();
            Controls.Add(button);
        }


    }
}

// ДатаВъезда + ДнейОтЦели
