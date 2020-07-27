using System.IO;
using System.Windows;
using System.Windows.Markup;

namespace NonCompileXaml
{
    /// <summary>
    /// Xaml2009.xaml 的交互逻辑
    /// </summary>
    public partial class Xaml2009Window : Window
    {
        public Xaml2009Window()
        {
            //InitializeComponent();
        }

        public static Xaml2009Window LoadWindowFromXaml(string xamlFile)
        {
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                Xaml2009Window window = (Xaml2009Window)XamlReader.Load(fs);
                return window;
            }
        }

        public class Person
        { 
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public override string ToString()
            {
                return FirstName + " " + LastName
            }

        }


    }
}
