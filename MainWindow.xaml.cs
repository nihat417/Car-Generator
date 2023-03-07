using Car_Generator.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
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

namespace Car_Generator
{
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            var directory = new DirectoryInfo(@"..\..\..\Car Data");

            foreach (var item in directory.GetFiles())
            {

                if (item.Extension == ".json")
                {
                    var jsonText = File.ReadAllText(item.FullName);
                    var listCar = JsonSerializer.Deserialize<List<Car>>(jsonText);

                    if (listCar is null)
                        continue;

                    foreach (var car in listCar)
                    {



                        // lblTimeLoading.Text = watch.Elapsed.ToString();
                        Uc_Controls uC_Car = new(car);
                        CarsGroupbox.Children.Add(uC_Car);
                        
                    }
                }



            }
                
            
        }
    }
}
