using TripOnboarding.ViewModels;

namespace TripOnboarding.Views;

public partial class TripOnboardingView : ContentPage
{
    public TripOnboardingView(TripOnboardingViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}