using System;
using Prism.Navigation;
using SamplePrismApp.Common.Interface;

namespace SamplePrismApp.Interface
{
	public interface IViewModelBase: INavigatedAware
    {
        bool IsActivityInProgress { get; set; }

        INavigationServiceExtension NavigationService { get; set; }
        void HidePopUpOnBackClick();

        Thickness PageTitleMargin { get; set; }
        void LaunchSessionTimeoutPage();
    }
}

