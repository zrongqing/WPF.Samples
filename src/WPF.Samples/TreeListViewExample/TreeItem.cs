using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TreeListViewExample;

public class TreeItem
{
    public string   Name         { get; set; }
    public string   Type         { get; set; }
    public DateTime ModifiedDate { get; set; }
    public ObservableCollection<TreeItem> Children     { get; set; } = new ObservableCollection<TreeItem>();
    
    private bool isExpanded;
    [Display(AutoGenerateField = false)]
    public bool IsExpanded
    {
        get
        {
            return this.isExpanded;
        }
        set
        {
            if (this.isExpanded != value)
            {
                this.isExpanded = value;
                //
                // this.LoadChildren();
                //
                // OnPropertyChanged("IsExpanded");
            }
        }
    }
}