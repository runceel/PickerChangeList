using PickerChangeList.Models;
using Prism.Navigation;
using Reactive.Bindings;
using System.Linq;

namespace PickerChangeList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReadOnlyReactiveCollection<Model1> Model1s { get; }
        public ReactiveProperty<Model1> Model1 { get; }

        public ReadOnlyReactiveCollection<PageContentViewModel> PageContentViewModels { get; }
        public MainPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService)
        {
            Model1s = coreModel.Model1s.ToReadOnlyReactiveCollection();
            Model1 = new ReactiveProperty<Model1>(Model1s.First());
            PageContentViewModels = Model1.Value.Model2s.ToReadOnlyReactiveCollection(x => new PageContentViewModel(x));
        }
    }
}
