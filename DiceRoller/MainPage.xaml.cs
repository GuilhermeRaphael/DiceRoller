using DiceRoller.Models;

namespace DiceRoller

{
    public partial class MainPage : ContentPage
    {
        Sequencia jogo = new Sequencia();
        int totalLadoOposto = 0;
        int maxTentativas = 25;

        public MainPage()
        {
            InitializeComponent();
            
        }



        private void DiceButton_Clicked(object sender, EventArgs e)
        {

            if (totalLadoOposto >= maxTentativas)
            {
                DisplayAlert("Atenção", "Tentativas máximas utilizadas", "Ok");
                DiceButton.IsEnabled = false;
                return;
            }

            /*
                        Dice dado = new Dice();
                        int numeroEscolhido = SelecaoPicker.SelectedIndex + 1;
                        dado.Sortear(numeroEscolhido);

                        Dado_1.Source = "dado_" + dado.FaceParaCima + ".PNG";

                        totalLadoOposto += dado.FaceParaBaixo;

                        if (jogo.CheckWinner(dado.FaceParaCima, numeroEscolhido)) 
                        {
                            DisplayAlert("Parabéns", "Você venceu!", "Ok");
                        }
                        else
                        {
                            DisplayAlert("Se ferrou", "Você perdeu!", "Ok");
                        }

                        UpdateLabels(); // Atualiza os labels após cada jogada
                    }



                    private void UpdateLabels()
                    {
                        PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
                        StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia.";
               */
        }
    }

}