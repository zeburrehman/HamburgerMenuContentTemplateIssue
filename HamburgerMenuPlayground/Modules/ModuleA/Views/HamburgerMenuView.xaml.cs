using HamburgerMenuPlayground.Modules.ModuleA.ViewModels;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HamburgerMenuPlayground.Modules.ModuleA.Views
{
    /// <summary>
    /// Interaction logic for HamburgerMenuView.xaml
    /// </summary>
    public partial class HamburgerMenuView : UserControl
    {
        public HamburgerMenuView()
        {
            InitializeComponent();
        }

        private void HamburgerMenu_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e)
        {
            //var vm = (HamburgerMenuViewModel)this.DataContext;
            ((HamburgerMenu)sender).Content = e.ClickedItem;
        }
    }
}
