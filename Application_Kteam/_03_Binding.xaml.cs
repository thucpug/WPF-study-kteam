using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for _03_Binding.xaml
    /// </summary>
    public partial class _03_Binding : Window, INotifyPropertyChanged
    {
        private string dataBiding;
        public string DataBiding
        {
            get { return this.dataBiding; }
            set
            {
                dataBiding = value;
                OnPropertyChanged("DataBiding");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string data)
        {
            if (data != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(data));
            }
        }


        public _03_Binding()
        {
            InitializeComponent();
            this.DataContext = this;
            dataBiding = "thuc dep tai";
        }
    }
}
