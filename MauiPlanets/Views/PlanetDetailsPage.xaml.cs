using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetDetailsPage : ContentPage
{
	public PlanetDetailsPage(Planet planets)
	{
		InitializeComponent();
		this.BindingContext = planets;
	}

	async void BackButton_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PopAsync();
	}
}