using CommunityToolkit.Mvvm.ComponentModel;


namespace SmartSystem_WpfApp.MVVM.ViewModels;


public partial class KitchenViewModel : ObservableObject
{
    [ObservableProperty]
    private string currentWeatherCondition = "\uf0c2";

    [ObservableProperty]
    private string currentTemperature = "-10";

    [ObservableProperty]
    private string currentTime = "14:00:00";

    [ObservableProperty]
    private string currentDate = "2023-01-01";
}
