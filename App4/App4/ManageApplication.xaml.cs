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
    /// Interaction logic for ManageApplication.xaml
    /// </summary>
    /// 

 
    public partial class ManageApplication : Window
    {

        List<Class1> play = new List<Class1>();
        

        public ManageApplication()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            int low = 15;
            int high = 5000;
            int result = r.Next(high - low) + low;
            play.Add(new Class1(Name.Text, (Class1.Types)ComboTypes.SelectedItem,result,false, description.Text));


            var names = from play in play select play;
            //var prices = from play in product_Val select play;

            Cartlst2.DataContext = names;

        }
    }
}
