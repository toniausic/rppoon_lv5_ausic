using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_lv5
{
    public static class Tester
    {
        public static void RunTask1()
        {
            Box box1 = new Box("velika kutija");
            Product product1 = new Product("crvena igračka", 12.99 , 3.99);
            Product product2 = new Product("crvena igračka", 12.99, 3.99);
            Product product3 = new Product("crvena igračka", 12.99, 3.99);

            Box box2 = new Box("manja kutija");

            box2.Add(product2);
            box2.Add(product3);
            box1.Add(box2);
            box1.Add(product1);
            Console.WriteLine(box1.Description());
        }
        
        public static void RunTask2()
        {
            Box box1 = new Box("nova metalna kutija");
            Product product = new Product("tipkovnica", 39.99, 2.5);
            box1.Add(product);
            ShippingService service = new ShippingService(5);
            Console.WriteLine("The shipping for the keyboard would amount to:" + service.CalculateShippingPrice(product));

        }
        public static void RunTask3()
        {
            //error, compiler mi ne može naći ovaj filepath na računalu
            IDataset dataset = new Dataset("C:\\Users\\Toni\\OneDrive\\Desktop\\rppoon_lv5\\rppoon_lv5\\csvText.csv");
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.Print(dataset);
            IDataset virtualProxy = new VirtualProxyDataset("C:\\Users\\Toni\\OneDrive\\Desktop\\rppoon_lv5\\rppoon_lv5\\csvText.csv"); 
            printer.Print(virtualProxy);

            User user1 = User.GenerateUser("Toni");
            User user2 = User.GenerateUser("Luka");

            ProtectionProxyDataset protectionProxy = new ProtectionProxyDataset(user1);
            printer.Print(protectionProxy);

          
            protectionProxy = new ProtectionProxyDataset(user2);
            printer.Print(protectionProxy);

        }

        public static void RunTask4()
        {
            LoggingProxyDataset loggingProxy = new LoggingProxyDataset("C:\\Users\\Toni\\OneDrive\\Desktop\\rppoon_lv5\\rppoon_lv5\\csvText.csv");
            DataConsolePrinter loggingPrinter = new DataConsolePrinter();
            loggingPrinter.Print(loggingProxy);
            loggingProxy.LogMessage("Hello World!");

        }

        public static void RunTask5()
        {
            ITheme theme = new LightTheme();
            Note note = new ReminderNote("pozdrav svima!", theme);
            note.Show();

            theme = new MyTheme();
            note.Theme = theme;
            note.Show();
        }

        public static void RunTask6()
        {
            GroupNote guysNote = new GroupNote("It's so bright!", new LightTheme());
            guysNote.AddName("Toni");
            guysNote.AddName("Luka");
            guysNote.Show();

            GroupNote girlsNote = new GroupNote("Why is the background red?", new MyTheme());
            girlsNote.AddName("Ana");
            girlsNote.AddName("Jana");
            girlsNote.Show();
        }

        public static void RunTask7()
        {
            Notebook notebook = new Notebook();
            notebook.ChangeTheme(new MyTheme());
            ReminderNote note = new ReminderNote("zadnji zadatak!!!", new LightTheme());
            notebook.AddNote(note);
            notebook.Display();
            notebook.ChangeTheme(new LightTheme());
            ReminderNote note2 = new ReminderNote("uskoro kraj!!", new MyTheme());
            notebook.AddNote(note2);
            notebook.Display();
        }
    }
}
