using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace TreeListViewExample;

public class TreeListView : TreeView
{
    public static readonly DependencyProperty ViewProperty = DependencyProperty.Register(nameof(View),typeof(ViewBase),typeof(TreeListView));

    static TreeListView()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeListView), new FrameworkPropertyMetadata(typeof(TreeListView)));
    }

    public ObservableCollection<GridViewColumn> Columns
    {
        get { return (ObservableCollection<GridViewColumn>)GetValue(ColumnsProperty); }
        set { SetValue(ColumnsProperty, value); }
    }

    public static readonly DependencyProperty ColumnsProperty =
        DependencyProperty.Register("Columns", typeof(ObservableCollection<GridViewColumn>), 
                                    typeof(TreeListView), new UIPropertyMetadata(new ObservableCollection<GridViewColumn>()));
    
    public ViewBase View
    {
        get { return (ViewBase)GetValue(ViewProperty); }
        set { SetValue(ViewProperty, value); }
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new TreeListViewItem();
    }

    protected override bool IsItemItsOwnContainerOverride(object item)
    {
        return item is TreeListViewItem;
    }
}

public class TreeListViewItem : TreeViewItem
{
    static TreeListViewItem()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(TreeListViewItem), new FrameworkPropertyMetadata(typeof(TreeListViewItem)));
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new TreeListViewItem();
    }

    protected override bool IsItemItsOwnContainerOverride(object item)
    {
        return item is TreeListViewItem;
    }
}