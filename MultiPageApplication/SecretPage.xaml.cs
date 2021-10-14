using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiPageApplication
{
    /// <summary>
    /// Логика взаимодействия для SecretPage.xaml
    /// </summary>
    public partial class SecretPage : Page
    {
        public SecretPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new FirstPage());
        }
    }
}
