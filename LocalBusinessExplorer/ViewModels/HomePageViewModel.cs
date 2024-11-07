using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using LocalBusinessExplorer.Models;
using LocalBusinessExplorer.Services;

public class HomePageViewModel
{
    private readonly GooglePlaceService _placeService;
    public ObservableCollection<Place> RetailShops { get; set; }

    public HomePageViewModel()
    {
        _placeService = new GooglePlaceService();
        RetailShops = new ObservableCollection<Place>();
    }

    public async Task LoadRetailShops(double latitude, double longitude)
    {
        var shops = await _placeService.GetNearbyRetailShops(latitude, longitude);
        foreach (var shop in shops)
        {
            RetailShops.Add(shop);
        }
    }
}
