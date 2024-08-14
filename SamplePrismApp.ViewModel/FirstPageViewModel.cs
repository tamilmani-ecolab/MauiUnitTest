using System;
using SamplePrismApp.Interface;
using SamplePrismApp.Interface.ViewModels;
using SamplePrismApp.Models;
using System.Collections.ObjectModel;

namespace SamplePrismApp.ViewModel
{
	public class FirstPageViewModel:BaseViewModel, IFirstPageViewModel
    {
        public ObservableCollection<Items> Items { get; set; }
        private readonly ApiService _apiService;

        public FirstPageViewModel()
		{
            Items = new ObservableCollection<Items>();
            _apiService = new ApiService();
            LoadData();
        }

        private async void LoadData()
        {
            var items = await _apiService.GetItemsAsync();
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            // Populate the Items collection with data
        
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public void OnLoadInitialization()
        {
            
        }
    }
}

