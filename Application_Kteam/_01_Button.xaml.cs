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
    /// Interaction logic for _01_Button.xaml
    /// </summary>
    public partial class _01_Button : Window
    {
        Button btnOk;
        public _01_Button()
        {
            InitializeComponent();
            btnOk = new Button();
            btnOk.Content = "Ok";
            grbButton.Children.Add(btnOk);
            btnOk.Click += BtnOk_Click;

        }

        private void grbButton_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Inlines.Add("Done");
            btnOk.Content = textBlock;
      
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok done!");
        }
    }
}
