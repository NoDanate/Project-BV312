using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl() : base()
        {
        }

        //смена контролеров
        public static void SwitchToControl(Control parent, MyUserControl newControl)
        {
            if (parent == null) return; // Проверяем, что родительский элемент существует

            // Очищаем все дочерние элементы родителя
            parent.Controls.Clear();

            // Добавляем новый контрол
            newControl.Dock = DockStyle.Fill;
            parent.Controls.Add(newControl);
        }
    }
}
