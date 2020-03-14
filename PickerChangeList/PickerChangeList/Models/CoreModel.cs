using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PickerChangeList.Models
{
    public class CoreModel : BindableBase
    {
        public ObservableCollection<Model1> Model1s { get; }
        public CoreModel()
        {
            Model1s = new ObservableCollection<Model1>() {
                new Model1(new List<Model2>(){
                    new Model2(){Name = "あべ1"},
                    new Model2(){Name = "あべ2"},
                    new Model2(){Name = "あべ3"}
                }){Name = "あべ" },
                new Model1(new List<Model2>(){
                    new Model2(){Name = "いとう1"},
                    new Model2(){Name = "いとう2"},
                    new Model2(){Name = "いとう3"},
                    new Model2(){Name = "いとう4"}
                }){Name = "いとう" },
                new Model1(new List<Model2>(){
                    new Model2(){Name = "うえだ1"},
                    new Model2(){Name = "うえだ2"},
                    new Model2(){Name = "うえだ3"},
                    new Model2(){Name = "うえだ4"},
                    new Model2(){Name = "うえだ5"}
                }){Name = "うえだ" }
            };
        }
    }
}
