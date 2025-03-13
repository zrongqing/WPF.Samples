using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using TreeListVIew.Models;
using TreeViewItem = TreeListVIew.Models.TreeViewItem;

namespace TreeListVIew.Views
{
    /// <summary>
    /// TreeGridDemo.xaml 的交互逻辑
    /// </summary>
    public partial class TreeGridDemo : Window, INotifyPropertyChanged
    {
        private IEnumerable<TreeViewItem> displayTree;

        public TreeGridDemo(IEnumerable<TreeViewItem> displayTree)
        {
            DisplayTree = displayTree;
            InitializeComponent();
        }

        /// <summary>
        /// 视图显示树
        /// </summary>
        public IEnumerable<TreeViewItem> DisplayTree
        {
            get => displayTree;

            set
            {
                displayTree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayTree)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void ContentPresenter_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is ContentPresenter content)
                content.Margin = new Thickness(0);
        }
    }
}
