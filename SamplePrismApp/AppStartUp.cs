using System;
using SamplePrismApp.Common.AppPages;
using SamplePrismApp.Interface;
using SamplePrismApp.Interface.ViewModels;
using SamplePrismApp.ViewModel;
using SamplePrismApp;
namespace SamplePrismApp
{
    public static class AppStartUp
    {
        public static void ConfigureAppServices(PrismAppBuilder prism)
        {
            prism.ConfigureServices(services =>
            {
                services.AddTransient<IViewModelBase, BaseViewModel>();
                services.AddTransient<IFirstPageViewModel, FirstPageViewModel>();
                services.AddTransient<ISecondPageViewModel, SecondPageViewModel>();
                services.AddTransient<IThirdPageViewModel, ThirdPageViewModel>();
                services.AddTransient<IFourthPageViewModel, FourthPageViewModel>();
                services.AddTransient<IFifthPageViewModel, FifthPageViewModel>();
                services.AddTransient<ISixthPageViewModel, SixthPageViewModel>();
                services.AddTransient<ISeventhPageViewModel, SeventhPageViewModel>();
                services.AddTransient<IEighthPageViewModel, EighthPageViewModel>();
                services.AddTransient<INinethPageViewModel, NinethPageViewModel>();
                services.AddTransient<ITenthPageViewModel, TenthPageViewModel>();
            });
            prism.RegisterTypes(containerRegistry =>
            {
                containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<FirstPage, FirstPageViewModel>(AppPages.FirstPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>(AppPages.SecondPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<ThirdPage, ThirdPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<FourthPage, FourthPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<FifthPage, FifthPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<SixthPage, SixthPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<SeventhPage, SeventhPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<EighthPage, EighthPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<NinethPage, NinethPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
                containerRegistry.RegisterForNavigation<TenthPage, TenthPageViewModel>(AppPages.MainPageKey).RegisterInstance(SemanticScreenReader.Default);
            }).OnInitialized(() =>{

            }).OnAppStart(navigationService => navigationService.CreateBuilder()
                    .AddSegment<FirstPageViewModel>()
                    .NavigateAsync(HandleNavigationError));
        }

        private static void HandleNavigationError(Exception ex)
        {
            Console.WriteLine(ex);
            System.Diagnostics.Debugger.Break();
        }
    }
}

