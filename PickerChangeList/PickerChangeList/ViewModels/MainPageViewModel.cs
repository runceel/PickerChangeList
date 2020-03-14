using PickerChangeList.Models;
using Prism.Navigation;
using Reactive.Bindings;
using System.Linq;

namespace PickerChangeList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReadOnlyReactiveCollection<PageContentListViewModel> Model1s { get; }
        public ReactiveProperty<PageContentListViewModel> Model1 { get; }

        public MainPageViewModel(INavigationService navigationService, CoreModel coreModel) : base(navigationService)
        {
            Model1s = coreModel.Model1s.ToReadOnlyReactiveCollection(x => new PageContentListViewModel(x));
            Model1 = new ReactiveProperty<PageContentListViewModel>(Model1s.First());
        }
    }
}
