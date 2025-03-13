using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TreeListVIew.Models;

public partial class TreeViewItem :ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private DateTime _startDate;
    
    [ObservableProperty]
    private DateTime _endDate;
    
    [ObservableProperty]
    private ObservableCollection<TreeViewItem> _children;
}