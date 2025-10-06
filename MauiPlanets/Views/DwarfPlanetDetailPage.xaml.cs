using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class DwarfPlanetDetailPage : ContentPage
{
    public DwarfPlanetDetailPage(DwarfPlanet dwarfPlanet)
    {
        InitializeComponent();
        this.BindingContext = dwarfPlanet;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
}