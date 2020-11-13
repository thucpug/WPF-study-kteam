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
using System.Windows.Shapes;

namespace Application_Kteam
{
    /// <summary>
    /// Interaction logic for _02_TextBox.xaml
    /// </summary>
    public partial class _02_TextBox : Window
    {
        public _02_TextBox()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
        {
            txtValuePassword.Text = txtPassword.Password;

        }
    }
}
