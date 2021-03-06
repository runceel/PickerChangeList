﻿using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PickerChangeList.Models
{
    public class Model1 : BindableBase
    {

        public string Name { get => name; set => SetProperty(ref name, value); }
        private string name;

        public ObservableCollection<Model2> Model2s { get; }

        public Model1(List<Model2> m)
        {
            Model2s = new ObservableCollection<Model2>(m);
        }
    }
}
