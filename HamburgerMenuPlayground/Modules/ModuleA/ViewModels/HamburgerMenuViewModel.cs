using HamburgerMenuPlayground.Modules.ModuleA.Models;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using FontAwesome.WPF;
using System.Windows.Input;
using Prism.Commands;
using System;

namespace HamburgerMenuPlayground.Modules.ModuleA.ViewModels
{
    public class HamburgerMenuViewModel : BindableBase
    {
        private ObservableCollection<StepView> _stepViews;
        public ObservableCollection<StepView> StepViews
        {
            get { return _stepViews; }
            set { _stepViews = value; }
        }

        private StepView _selectedStepView;
        public StepView SelectedStepView
        {
            get { return _selectedStepView; }
            set { _selectedStepView = value; }
        }

        private object _contentDataContext;
        public object ContentDataContext
        {
            get { return _contentDataContext; }
            set { SetProperty(ref _contentDataContext, value); }
        }
        
        private ICommand _itemClickCommand;
        public ICommand ItemClickCommand
        {
            get { return _itemClickCommand; }
            set { _itemClickCommand = value; }
        }
        
        public HamburgerMenuViewModel()
        {
            ItemClickCommand = new DelegateCommand<object>(ItemClickedEvent);
            StepViews = new ObservableCollection<StepView>
            {
                new StepView{ Name = "ResourceManagement", Description = "Resource Management", IconImage = FontAwesomeIcon.UserCircleOutline },
                new StepView{ Name = "RunSettings", Description = "Run Settings", IconImage = FontAwesomeIcon.Cogs },
                new StepView{ Name = "Configurations", Description = "Configurations", IconImage = FontAwesomeIcon.Wrench },
                new StepView{ Name = "Diagnostics", Description = "Diagnostics", IconImage = FontAwesomeIcon.Stethoscope },
                new StepView{ Name = "ActivityMonitor", Description = "Activity Monitor", IconImage = FontAwesomeIcon.Gear },
                new StepView{ Name = "Reporting", Description = "Reporting", IconImage = FontAwesomeIcon.FileOutline }
            };
            
        }

        private void ItemClickedEvent(object dc)
        {
            ContentDataContext = dc;
        }
    }
}
