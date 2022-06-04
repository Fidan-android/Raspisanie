using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspisanieWinForms.Helpers
{
    class Helper
    {
        private static List<BaseForm> _BackStack = new List<BaseForm>();
        public static BaseForm BackStack
        {
            get
            {
                var last = _BackStack.Last();
                _BackStack.Remove(last);
                return last;
            }
            set
            {
                _BackStack.Add(value);
                _BackStack.Last().Hide();
            }
        }

        public static void Quit(bool IsClose = true)
        {
            (IsClose ? (Action)_BackStack.First().Close : BackStack.Show)();
        }
    }
}
