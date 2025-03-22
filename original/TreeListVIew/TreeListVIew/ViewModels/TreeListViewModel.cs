using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreeListVIew.Models;

namespace TreeListVIew.ViewModels;

public partial class TreeListViewModel :ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TreeViewItem> _treeViewItems;
    
    [RelayCommand]
    private void Test()
    {
        MessageBox.Show("测试");
    }
}