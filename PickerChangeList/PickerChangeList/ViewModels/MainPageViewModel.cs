using PickerChangeList.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickerChangeList.ViewModels {
    public class MainPageViewModel : ViewModelBase {

        public ReadOnlyReactiveCollection<Model1> Model1s { get; }
        public ReactiveProperty<Model1> Model1 { get; }
        public ReactiveProperty<Model2> Model2 { get; }

        public ReadOnlyReactiveCollection<PageContentViewModel> PageContentViewModels { get; }
        public MainPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService) {
            Model1s = coreModel.Model1s.ToReadOnlyReactiveCollection();
            Model1 = new ReactiveProperty<Model1>(Model1s.First());
            Model2 = new ReactiveProperty<Model2>(Model1.Value.Model2s.First());
            
            Model1.Subscribe(x => Model2.Value = x.Model2s.First());

            PageContentViewModels = Model1.Value.Model2s.ToReadOnlyReactiveCollection(x => new PageContentViewModel(x));
        }
    }
}
