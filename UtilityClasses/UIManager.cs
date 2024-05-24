using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets_Consert_System.UtilityClasses
{
    public static class UIManager
    {
        public delegate void initOldForm();
        public static void SwitchForm(Form startForm, Form newForm, initOldForm funcs = null)
        {
            startForm.Hide();
            newForm.FormClosed += (s, args) =>
            {
                startForm.Show();
                if(funcs != null)
                    funcs();
            };
            newForm.Show();
        }
    }
}
