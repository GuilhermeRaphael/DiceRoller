namespace DiceRoller.Views;

using DiceRoller.ViewModels;

public partial class GameView : ContentPage
{
	public GameView()
	{
		InitializeComponent();
		BindingContext = new GameViewModel(); 
	}
}