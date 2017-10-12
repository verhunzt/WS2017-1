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

namespace Einheit3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GeoObject> Shapes = new List<GeoObject>();
        public MainWindow()
        {
            InitializeComponent();
            cboForm.ItemsSource = new List<string> { "Rechteck", "Kreis" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Shapes.Add(new GeoObject(
                cboForm.SelectedItem.ToString(), 
                int.Parse(tboX.Text),
                int.Parse(tboY.Text), 
                int.Parse(tboBreite.Text), 
                int.Parse(tboLaenge.Text)));
            dgridTabelle.ItemsSource = null;
            dgridTabelle.ItemsSource = Shapes;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Shapes = null;
            Shapes.Remove((GeoObject)dgridTabelle.SelectedItem);
            //dgridTabelle.ItemsSource = null;
            //dgridTabelle.ItemsSource = Shapes;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var temp = ((GeoObject)dgridTabelle.SelectedItem);

            Shape geoObject = null;
            switch (temp.Shape)
            {
                case "Rechteck":
                    geoObject = new Rectangle()
                    {
                        Height = temp.Height,
                        Width = temp.Width,
                        Stroke = new SolidColorBrush(Colors.Red),
                        StrokeThickness = 1,
                    };


                    break;
                case "Kreis":
                    geoObject = new Ellipse()
                    {
                        Height = temp.Height,
                        Width = temp.Width,
                        Stroke = new SolidColorBrush(Colors.Red),
                        StrokeThickness = 1

                    };
                    break;
                default:
                    break;
         
            }
            canSeite.Children.Add(geoObject);
            geoObject.SetValue(Canvas.TopProperty, (double)temp.PosX);
            geoObject.SetValue(Canvas.LeftProperty, (double)temp.PosY);
        }
    }
}
