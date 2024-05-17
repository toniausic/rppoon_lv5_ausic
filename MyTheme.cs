using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    internal class MyTheme : ITheme
    {
        public string GetFooter(int width)
        {
            return new string('$', width);
        }

        public string GetHeader(int width)
        {
            return new string('$', width);
        }

        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }

        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
