using System;
namespace SamplePrismApp.Common.Interface
{
	public interface INavigationServiceExtension
	{
        Task NavigateAsync(string page);
        Task NavigateAsync(string page, INavigationParameters param);
        Task NavigatetoSamePageAsync(string page, INavigationParameters param);
        Task NavigatetoSamePageAsync(string page);
        Task GoBackAsync();
        Task GoBackAsync(INavigationParameters param);
        Task GoBackToRootAsync();
        Task NavigateModalAsync(string page, INavigationParameters param, bool useModalNavigation = true);
        Task<bool> IsExistInStack(string page);
        void RemovePage(string page);
        string GetNavigationUriPath();
    }
}

