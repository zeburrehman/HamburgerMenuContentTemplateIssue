using Prism.Mvvm;

namespace HamburgerMenuPlayground.Modules.ModuleA.Models
{
    public class StepView : BindableBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private object _iconImage;

        public object IconImage
        {
            get { return _iconImage; }
            set { SetProperty(ref _iconImage, value); }
        }

    }
}
