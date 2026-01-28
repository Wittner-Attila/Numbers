using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop;

public partial class MainWindow : Window
{
    public ObservableCollection<int> Numbers { get; private set; } =
        new ObservableCollection<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    public void AClicked(object sender, RoutedEventArgs e)
    {
        Numbers[0]++;
        Numbers[1]++;
        Numbers[3]++;
        Numbers[4]++;
    }

    public void BClicked(object sender, RoutedEventArgs e)
    {
        Numbers[1]++;
        Numbers[2]++;
        Numbers[4]++;
        Numbers[5]++;
    }

    public void CClicked(object sender, RoutedEventArgs e)
    {
        Numbers[3]++;
        Numbers[4]++;
        Numbers[6]++;
        Numbers[7]++;
    }

    public void DClicked(object sender, RoutedEventArgs e)
    {
        Numbers[4]++;
        Numbers[5]++;
        Numbers[7]++;
        Numbers[8]++;
    }
    public void Reset(object sender, RoutedEventArgs e)
    {
        for (int i = 0; i < Numbers.Count; i++)
        {
            Numbers[i] = 0;
        }
    }
}
