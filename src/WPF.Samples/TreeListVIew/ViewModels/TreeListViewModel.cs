using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TreeListVIew.Models;
using TreeListVIew.Views;

namespace TreeListVIew.ViewModels;

public partial class TreeListViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TreeViewItem> _treeViewItems;

    [RelayCommand]
    private void Test()
    {
        TreeViewItem root = new TreeViewItem()
        {
            Name = "Root",
        };

        for (int i = 0; i < 5; i++)
        {
            TreeViewItem level1 = new TreeViewItem()
            {
                Name = $"Level-{i}",
                Parent = root
            };

            root.Children.Add(level1);

            for (int j = 0; j < 10; j++)
            {
                TreeViewItem level2 = new TreeViewItem()
                {
                    Name = $"Level-{i}-{j}",
                    Parent = level1
                };

                level1.Children.Add(level2);
            }
        }

        List<TreeViewItem> roots = new List<TreeViewItem>() { root };

        TreeGridDemo win = new TreeGridDemo(roots);
        win.Show();

        //MessageBox.Show("测试");
    }
}