using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TreeListVIew.Models;

/// <summary>
/// 表示树视图中的一个项。
/// </summary>
public partial class TreeViewItem : ObservableObject
{
    private TreeViewItem? parent;

    private string _name = string.Empty;

    private DateTime _startDate = DateTime.Now;

    private DateTime _endDate = DateTime.Now;

    private ObservableCollection<TreeViewItem> _children = new ObservableCollection<TreeViewItem>();

    private bool isExpanded;
    private bool isSelected;

    /// <summary>
    /// 获取或设置项的名称。
    /// </summary>
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    /// <summary>
    /// 获取或设置项的开始日期。
    /// </summary>
    public DateTime StartDate
    {
        get => _startDate;
        set => SetProperty(ref _startDate, value);
    }

    /// <summary>
    /// 获取或设置项的结束日期。
    /// </summary>
    public DateTime EndDate
    {
        get => _endDate;
        set => SetProperty(ref _endDate, value);
    }

    /// <summary>
    /// 获取或设置项的子项集合。
    /// </summary>
    public ObservableCollection<TreeViewItem> Children
    {
        get => _children;
        set => SetProperty(ref _children, value);
    }

    /// <summary>
    /// 获取或设置项的父项。
    /// </summary>
    public TreeViewItem? Parent
    {
        get => parent;
        set => SetProperty(ref parent, value);
    }

    /// <summary>
    /// 是否展开
    /// </summary>
    public bool IsExpanded
    {
        get => isExpanded;

        set
        {
            isExpanded = value;
            OnPropertyChanged();
        }
    }


    /// <summary>
    /// 是否选中
    /// </summary>
    public bool IsSelected
    {
        get => isSelected;

        set
        {
            isSelected = value;
            OnPropertyChanged();
        }
    }

    public int Level
    {
        get
        {
            int level = 0;
            var tmp = Parent;
            while (tmp != null)
            {
                level++;
                tmp = tmp.Parent;
            }

            return level;
        }
    }
}
