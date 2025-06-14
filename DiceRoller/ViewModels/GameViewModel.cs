using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage; //colocar a primeira letra em minusculo

        [ObservableProperty]
        private string app;

        [ObservableProperty]
        private int selectedValue;

        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string escolhaPicker;

        [ObservableProperty]
        private int playerPoint;

        [ObservableProperty]
        private int streak;

        [ObservableProperty]
        private int totalOppositeSide;

        [ObservableProperty]
        private int maxAttempts = 25;

        private Sequencia jogo;




        public GameViewModel()
        {

            DiceImage = "dado_1.PNG";
            App = "Sorteio de dados";
            JogarCommand = new Command(Jogar);
            escolhaPicker = "Selecione o valor do dado";

            jogo = new Sequencia();
        }

        public ICommand JogarCommand { get; private set; }

        public void Jogar()
        {
            if (totalOppositeSide >= maxAttempts)
            {
                Resultado = "Atenção: Tentativas maximas utilizadas";
                return;
            }
            //Sortear um dado 
            Dice dice = new Dice();
            dice.Sortear();
            // DiceImage.Source = "dado_" + dice.FaceParaCima + ".PNG";

            DiceImage = "dado_" + dice.FaceParaCima + ".PNG";
            TotalOppositeSide += dice.FaceParaBaixo;

            /*
            if (dice.FaceParaCima == SelectedValue)
            {
                Resultado = "Vitoria!!!!";
            }
            else
            {
                Resultado = "Derrota!!";
            }
          */

            int numeroEscolhidoReal = SelectedValue + 1;


            if (jogo.CheckWinner(dice.FaceParaCima, numeroEscolhidoReal))
            {
                Resultado = "Parabéns: Você venceu!";
            }
            else
            {
                Resultado = "Que pena: Você perdeu!";
            }


            PlayerPoint = jogo.PlayerPoint;
            Streak = jogo.Streak;


        }



    }
}
