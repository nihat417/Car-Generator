using Car_Generator.Models;
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

namespace Car_Generator;


public partial class Uc_Controls : UserControl
{
    Car car=new Car();
    ImageSourceConverter imgsc = new ImageSourceConverter();

    public Uc_Controls(Car car)
    {
        InitializeComponent();
        this.car = car;
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
        string path = @$"{car.ImagePath}";
        ImageSource imageSource = (ImageSource)imgsc.ConvertFromString(path);
        
        İmagetxt.Source = imageSource;
        Maketxt.Text = car.Make;
        Modeltxt.Text = car.Model;
        Yeartxt.Text = car.Year.ToString();
    }
}
