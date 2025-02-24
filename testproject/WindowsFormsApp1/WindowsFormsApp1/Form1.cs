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
    public partial class Form1 : Form
    {
        private MainController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new MainController(this);
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //buttonMed.Visible = false;
            //buttonPolis.Visible = false;

            controller.StartMedicalScenario();
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            //label1.Visible = false;
            //buttonMed.Visible = false;
            //buttonPolis.Visible = false;

            controller.StartInsuranceScenario();
        }

        public void ResetToMainScreen()
        {
            // Очистить все динамические элементы
            this.Controls.Clear();

            // Восстановить начальный интерфейс
            InitializeComponent();
        }
    }
}
