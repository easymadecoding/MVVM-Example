using System;
using System.Collections.ObjectModel;

namespace MVVM_Example.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        public MainViewModel()
        {
            // Initialize the items (in a real app, you'd fetch them from a data source)
            Items.Add(new Item { Name = "Item 1" });
            Items.Add(new Item { Name = "Item 2" });
            Items.Add(new Item { Name = "Item 3" });
        }
    }

}

