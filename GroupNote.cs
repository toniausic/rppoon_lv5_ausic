using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    class GroupNote : Note
    {

        private List<string> names;
        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            names = new List<string>();
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine(this.GetFramedMessage());
            this.PrintNames();
            Console.ResetColor();
        }
        public void AddName(string name)
        {
            names.Add(name);
        }

        public void RemoveName(string name)
        {
            names.Remove(name);
        }

        public void PrintNames()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
