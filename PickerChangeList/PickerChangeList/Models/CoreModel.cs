using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickerChangeList.Models {
    public class CoreModel : BindableBase {
        public ObservableCollection<Model1> Model1s { get; private set; }
        public CoreModel() {
            Model1s = new ObservableCollection<Model1>() {
                new Model1(new List<Model2>(){
                    new Model2(){Name = "あべ1"},
                    new Model2(){Name = "あべ2"},
                    new Model2(){Name = "あべ3"}
                }){Name = "あべ" },
                new Model1(new List<Model2>(){
                    new Model2(){Name = "いとう1"},
                    new Model2(){Name = "いとう2"},
                    new Model2(){Name = "いとう3"}
                }){Name = "いとう" },
                new Model1(new List<Model2>(){
                    new Model2(){Name = "うえだ1"},
                    new Model2(){Name = "うえだ2"},
                    new Model2(){Name = "うえだ3"}
                }){Name = "うえだ" }
            };
        }
    }
}
