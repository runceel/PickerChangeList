using PickerChangeList.Models;
using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickerChangeList.ViewModels {
    public class PageContentViewModel : BindableBase {
        public ReactiveProperty<string> Name { get; }
        public PageContentViewModel(Model2 model2) {
            Name = model2.ToReactivePropertyAsSynchronized(x => x.Name);
        }
    }
}
