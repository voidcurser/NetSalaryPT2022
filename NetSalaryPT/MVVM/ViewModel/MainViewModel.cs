using NetSalaryPT.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSalaryPT.MVVM.ViewModel
{
    class MainViewModel:ObservableObject
    {
        public RelayCommand NetViewCommand { get; set; }
        public RelayCommand GrossViewCommand { get; set; }
        public NetSalaryCalculationViewModel NetSalaryVM { get; set; }
        public GrossSalaryCalculationViewModel GrossSalaryVM { get; set; }
        private object _currentView;
        
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            NetSalaryVM= new NetSalaryCalculationViewModel();
            GrossSalaryVM= new GrossSalaryCalculationViewModel();
            CurrentView = NetSalaryVM;

            NetViewCommand = new RelayCommand(x => { 
            CurrentView = NetSalaryVM; 
            });
            GrossViewCommand = new RelayCommand(x => { 
            CurrentView = GrossSalaryVM; 
            });

        }
    }
}
