using CommunityToolkit.Mvvm.ComponentModel;


namespace SmartSystem_WpfApp.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableObject currentViewModel;

    public MainViewModel()
    {
        currentViewModel = new KitchenViewModel();
    }
}
