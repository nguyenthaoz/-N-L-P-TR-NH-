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

namespace my2.view
{
    /// <summary>
    /// Interaction logic for addtaisan.xaml
    /// </summary>
    public partial class addtaisan : UserControl
    {
        public addtaisan()
        {
            InitializeComponent();
        }

        private void Button_dong_Click(object sender, RoutedEventArgs e)
        {
            // Ẩn khi nhấn nút
            this.Visibility = Visibility.Collapsed;
        }
    }
}
