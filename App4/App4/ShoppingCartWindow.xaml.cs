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

namespace App4
{
    /// <summary>
    /// Interaction logic for ShoppingCartWindow.xaml
    /// </summary>
    public partial class ShoppingCartWindow : Window
    {
        


        public ShoppingCartWindow()
        {
            InitializeComponent();
        }


        

        private void Cartlst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow win = new MainWindow();

           

            // pick up the selected index
            int i = Cartlst.SelectedIndex;
            // write LINQ query to select the player


            var selecetdPlayer = from play in win.product_Val
                                 where win.product_Val.ElementAt(i) == i
                                 select play;

          

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
