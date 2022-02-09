
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace prakt14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CarViewModel();
        }
        //xmlns:local="clr-namespace:prakt14"
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ((CarViewModel)DataContext).AddCar();
           

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((CarViewModel)DataContext).DeleteCar();
        }

       

        
        }
    }

