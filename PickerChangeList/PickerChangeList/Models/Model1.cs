using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PickerChangeList.Models {
    public class Model1 : BindableBase {

        public string Name { get => name; set => SetProperty(ref name, value); }
        private string name;

        public ObservableCollection<Model2> Model2s { get; private set; }

        public Model1(List<Model2> m) => Model2s = new ObservableCollection<Model2>(m);
    }
}
