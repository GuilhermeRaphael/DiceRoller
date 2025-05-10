namespace DiceRoller

{
    public partial class MainPage : ContentPage
    {
        Sequencia jogo = new Sequencia();

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void DiceButton_Clicked(object sender, EventArgs e)
        {
            Dice dado = new Dice();
            dado.Roller(SelecaoPicker.SelectedIndex+1);
            Dado_1.Source = "dado_"+Convert.ToString(dado.FaceParaCima) + ".PNG";


            int sorteio = dado.FaceParaCima;

            if (jogo.CheckWinner(SelecaoPicker.SelectedIndex, sorteio))
            {
                DisplayAlert("Parabéns", "Você venceu!", "Ok");
            }
            else
            {
                DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
            }

            PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
            StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia.";



        }
    }

}
