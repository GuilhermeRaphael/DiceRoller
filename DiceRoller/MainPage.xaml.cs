using Microsoft.UI.Xaml.Controls;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void DiceButton_Clicked(object sender, EventArgs e)
        {

            int pickerSelect = SelecaoPicker.SelectedIndex;

        }
    }

}
