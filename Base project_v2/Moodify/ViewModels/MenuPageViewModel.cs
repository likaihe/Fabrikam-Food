using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Moodify
{
	public class MenuPageViewModel
	{
		public ICommand GoHomeCommand { get; set; }
		public ICommand GoSecondCommand { get; set; }
        public ICommand GoMenuCommand { get; set; }
        public ICommand GoOrderCommand { get; set; }

        public MenuPageViewModel()
		{
			GoHomeCommand = new Command(GoHome);
			GoSecondCommand = new Command(GoSecond);
            GoMenuCommand = new Command(GoMenu);
            GoOrderCommand = new Command(GoOrder);
        }

		void GoHome(object obj)
		{
            App.RootPage.Detail = new NavigationPage(new HomePage());
			App.MenuIsPresented = false;
		}

		void GoSecond(object obj)
		{
            App.RootPage.Detail = new NavigationPage(new SecondPage());
            App.MenuIsPresented = false;
		}

        void GoMenu(object obj)
        {
            App.RootPage.Detail = new NavigationPage(new FabrikamManuPage());
            App.MenuIsPresented = false;
        }

        void GoOrder(object obj)
        {
            App.RootPage.Detail = new NavigationPage(new Views.OrderListPage());
            App.MenuIsPresented = false;
        }
    }
}
