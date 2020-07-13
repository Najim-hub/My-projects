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
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace App4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Class1> play = new List<Class1>();
        public Stack<String> info = new Stack<String>();
        public Stack<int> product_Val = new Stack<int>();
        ShoppingCartWindow shopping = new ShoppingCartWindow();

        int total = 0;
        public MainWindow()
        {

            InitializeComponent();

        
            Class1.Types Book = Class1.Types.Book;
            Class1.Types Movie = Class1.Types.Movie;
            Class1.Types Electronic = Class1.Types.Electronics;
            Class1.Types Blockbuster = Class1.Types.BlockBuster;

            Random r = new Random();

            int low = 15;
            int high = 5000;
            int result = r.Next(high - low) + low;

         
           

            play.Add(new Class1("MY HERO ACADEMIA", Movie, result,false,"Anime movie new to netflix"));
            play.Add(new Class1("FIRE AND ICE", Book, result,true,"Top selling book by my favorite authour"));

            ShoppingCartWindow tes = new ShoppingCartWindow();

            //Console.WriteLine(tes.test);

        }

        public int sell(int i)
        {
            int n;
            return n = i;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

            var selected =       (from pl in play
                                 where pl.P_Name == productName.Text
                                 select pl).ToList();

            if (selected.Count <= 0)
            {
                MessageBox.Show("Sorry,but this record does not exist", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                foreach (var p in selected)
                {
                    productName.Text = p.P_Name;
                    PriceBox.Text = p.Price.ToString();
                    ComboType.Text = p.P_type.ToString();
                    description.Text = p.Desc;
                    checkThat.IsChecked = p.Sale;

                }

            }
        }


        private void btnPurchase_Click(object sender, RoutedEventArgs e)
        {

            MyPopup.IsOpen = true;
        }

        private void btnDist_Click(object sender, RoutedEventArgs e)
        {
            shopping.Show();
        }

        private void PurchaseName_Click(object sender, RoutedEventArgs e)
        {

            MyPopup.IsOpen = false;
            string newName = productName.Text;
            string newDescription = description.Text;
            bool onSale = checkThat.IsChecked.Value;
            int OrderAmount = int.Parse(OrderBox.Text);
            int quantity = 0;

            Class1.Types types = (Class1.Types)ComboType.SelectedItem;

            if (Quantity.IsChecked.Value == true && Amount.IsChecked.Value == false)
            {
                quantity = int.Parse(OrderBox.Text);
            }
            else if (Quantity.IsChecked.Value == false && Amount.IsChecked.Value == true)
            {

                quantity = int.Parse(OrderBox.Text) * int.Parse(PriceBox.Text);

            }
            string uname = InputName.Text;

           
            Class2 pl = new Class2(uname, newName, types, quantity, onSale, newDescription);

            

            string stock = "USER: " +uname +" , "+ " Name of Product: " + newName +  " "+ "TYPE: "+
                types.ToString()+ " , " + " Product Value: " + quantity+ " , " + " Sale status: " + 
                onSale.ToString()+ " , " + " Description: " + newDescription;

              info.Push(stock);

            if (info.Count == 0)
            {

                total += quantity;

            }
            else
            {
                for (int i = 1; i <= info.Count; i++)
                {
                    total += quantity;
                }
            }

              product_Val.Push(quantity);


            var names = from play in info select play;
            //var prices = from play in product_Val select play;

            shopping.Cartlst.DataContext = names;
            shopping.purchaseBox.Text = product_Val.Peek().ToString();
            shopping.OrderTotal.Text = total.ToString();
          

            shopping.Show();

        }

        
            void OnLoad(object sender, RoutedEventArgs e)
        {
            ComboType.ItemsSource = Enum.GetValues(typeof(Types)).Cast<Types>();
            ComboType.SelectedItem = "Book";
        }

        private void btnMan_Click(object sender, RoutedEventArgs e)
        {

            ManageApplication man = new ManageApplication();
            man.Show();

        }








}



    }

