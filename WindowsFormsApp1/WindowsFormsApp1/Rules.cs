using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Rules
    {
        private UserData userData;
        private MainController controller;

        public Rules(UserData userData, MainController cntr)
        {
            this.userData = userData;
            this.controller = cntr;
        }

        public int? DaysLeft
        {
            get
            {
                return (int)((DateTime.Now - userData.SelectedDate).TotalDays);
            }
        }

        public void CheckDate()
        {
            if(DateTime.Now < userData.SelectedDate)
            {
                MessageBox.Show("Неверная дата. Укажите правильную дату.");
                controller.ShowDateControl();
            }
            else
            {
                if (DaysLeft > 91)
                {
                    MessageBox.Show("Вы просрочили срок получения результатов мед.освидетельствования. Вам необходимо обратиться в миграционную службу.");
                    controller.Reset();
                }
                else
                {
                    if (userData.Purpose == null)
                        controller.ShowPurposeControl();
                    else
                        controller.ShowOrganizationControl();
                }
            }
        }

        public void CheckPurpose()
        {
            if (userData.Citizenship != null)
            {
                if (userData.Purpose == "Трудоустройство")
                    controller.ShowInsuranceOrganizationControl();
                else
                {
                    MessageBox.Show($"Вам не нужно получать полис");
                    controller.Reset();
                }
            }
            else if (DaysLeft > 30)
            {
                if (userData.Purpose == "Трудоустройство")
                {
                    MessageBox.Show($"К сожалению, вы просрочили срок получения на {DaysLeft - 30} дней. Обратитесь в миграционную службу.");
                    controller.Reset();
                }
                else if (userData.Purpose == "Длительное пребывание(более 90 дней)")
                    controller.ShowOrganizationControl();
                else
                {
                    MessageBox.Show("Вам не нужно получать результаты мед.освидетельствования.");
                    controller.Reset();
                }
            }
            else //если DaysLeft < 30
            {
                if (userData.Purpose == "Трудоустройство")
                    controller.ShowOrganizationControl();
                else if (userData.Purpose == "Длительное пребывание(более 90 дней)")
                    controller.ShowOrganizationControl();
                else
                {
                    MessageBox.Show("Вам не нужно получать результаты мед.освидетельствования.");
                    controller.Reset();
                }
            }
        }

        public DateTime ReturnDateForOrg()
        {
            if (userData.Purpose == "Трудоустройство")
                return userData.SelectedDate.AddDays(30);
            else if (userData.Purpose == "Длительное пребывание(более 90 дней)")
                return userData.SelectedDate.AddDays(90);
            else
                return DateTime.Now;
        }

        public void CheckCitizenship()
        {
            if (Enum.GetNames(typeof(Country)).Contains(userData.Citizenship) && userData.Purpose == null)
                controller.ShowPurposeControl();
            else if (Enum.GetNames(typeof(Country)).Contains(userData.Citizenship) && userData.Purpose == "Трудоустройство")
                controller.ShowInsuranceOrganizationControl();
            else
            {
                MessageBox.Show("Вам не нужно получать полис.");
                controller.Reset();
            }
        }

        //Enum.GetNames(typeof(Country)).Contains(userData.Purpose)

    }
}
