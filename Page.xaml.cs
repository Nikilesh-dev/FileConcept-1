using System;
using System.Collections.Generic;
using System.IO;
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

namespace file_Project
{
    /// <summary>
    /// Interaction logic for Page.xaml
    /// </summary>
    public partial class Page
    {
        public Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        
            File.WriteAllText("A:\\"+txtName.Text+".txt", txtpara.Text);
        }
    }
}
