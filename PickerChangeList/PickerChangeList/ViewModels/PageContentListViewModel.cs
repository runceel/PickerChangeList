using PickerChangeList.Models;
using Prism.Mvvm;
using Prism.Navigation;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;

namespace PickerChangeList.ViewModels
{
    public class PageContentListViewModel : BindableBase, IDisposable
    {
        private readonly CompositeDisposable _disposables = new CompositeDisposable();
        public ReactiveProperty<string> Name { get; }
        public ReadOnlyReactiveCollection<PageContentViewModel> PageContents { get; }
        public PageContentListViewModel(Model1 model)
        {
            Name = model.ToReactivePropertyAsSynchronized(x => x.Name)
                .AddTo(_disposables);
            PageContents = model.Model2s
                .ToReadOnlyReactiveCollection(x => new PageContentViewModel(x))
                .AddTo(_disposables);
        }

        public void Dispose() => _disposables.Dispose();
    }
}
