using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PickerChangeList.Models {
    public class Model2 : BindableBase {

        public string Name { get => name; set => SetProperty(ref name, value); }
        private string name;
    }
}
