using System;
using SamplePrismApp.Common.Interface;
using SamplePrismApp.Interface;

namespace SamplePrismApp.ViewModel
{
	public class BaseViewModel : BindableBase, IViewModelBase, INavigatedAware, IInitialize, IDestructible
    {
		public BaseViewModel()
		{
		}

        public bool IsActivityInProgress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public INavigationServiceExtension NavigationService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Thickness PageTitleMargin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Destroy()
        {
        }

        public void HidePopUpOnBackClick()
        {
          
        }

        public void Initialize(INavigationParameters parameters)
        {
            
        }

        public void LaunchSessionTimeoutPage()
        {
            
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}

