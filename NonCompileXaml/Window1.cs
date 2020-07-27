using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace NonCompileXaml
{
    public class Window1 : Window
    {
        private Button button1;

        public Window1(string xamlFile)
        {
            InitializeComponent(xamlFile);
        }

        private void InitializeComponent(string xamlFile)
        {
            this.Width = this.Height = 285;
            this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            DependencyObject rootElement;
            using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(fs);
            }

            this.Content = rootElement;

            FrameworkElement frameworkElement = (FrameworkElement)rootElement;
            button1 = (Button)frameworkElement.FindName("button1");

            button1.Click += new RoutedEventHandler(button1_Click);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you.";
        }
    }
}
