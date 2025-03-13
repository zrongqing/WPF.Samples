using System.Windows.Controls;
using CommunityToolkit.Mvvm.Input;
using TreeListVIew.ViewModels;

namespace TreeListVIew.Views;

public partial class TreeListView : UserControl
{
    public TreeListView()
    {
        this.ViewModel = new();
        this.DataContext = this;
        
        InitializeComponent();
    }

    public TreeListViewModel ViewModel { get; set; }


}