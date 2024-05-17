﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    class ReminderNote : Note
    {
        public ReminderNote(string message, ITheme theme) : base(message, theme) { }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
