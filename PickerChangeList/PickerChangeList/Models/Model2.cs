using Prism.Mvvm;


namespace PickerChangeList.Models
{
    public class Model2 : BindableBase
    {

        public string Name { get => name; set => SetProperty(ref name, value); }
        private string name;
    }
}
