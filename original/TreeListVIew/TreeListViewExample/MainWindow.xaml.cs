using System.Collections.ObjectModel;
using System.Windows;

namespace TreeListViewExample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
       InitializeComponent();
       DataContext = new MyDataContext();
    }
    
    public ObservableCollection<TreeItem> TreeItems { get; set; } = new ObservableCollection<TreeItem>();
}