using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.CustomControlLib
{
    public class MyTextBox : TextBox
    {
        public enum CalismaMod
        {
            Normal,
            Harf,
            Rakam
        };
        public CalismaMod Mod { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
        switch (Mod)
            {
                case CalismaMod.Normal:
                    base.OnKeyPress(e);
                    break;
                case CalismaMod.Harf:
                    e.Handled = char.IsDigit(e.KeyChar);
                    break;
                case CalismaMod.Rakam:
                    e.Handled = char.IsLetter(e.KeyChar);
                    break;
                default:
                    break;
            }
}
    }
}
