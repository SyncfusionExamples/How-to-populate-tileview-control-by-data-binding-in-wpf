using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TileViewControl_DB
{
    public class ViewModel
    {
        public ObservableCollection<Model> TileItems { get; set; }
        public ViewModel()
        {
            TileItems = new ObservableCollection<Model>();
            PopulateData();
        }

        private void PopulateData()
        {
            Model model1 = new Model() { Header = "Item1", Content = "TileViewItem1" };
            Model model2 = new Model() { Header = "Item2", Content = "TileViewItem2" };
            Model model3 = new Model() { Header = "Item3", Content = "TileViewItem3" };
            Model model4 = new Model() { Header = "Item4", Content = "TileViewItem4" };

            TileItems.Add(model1);
            TileItems.Add(model2);
            TileItems.Add(model3);
            TileItems.Add(model4);
        }
    }
}
