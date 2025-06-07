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

        

        

       public GameViewModel() {

            DiceImage = "dado_1.PNG";
            App = "Sorteio de dados";
            JogarComamand = new Command(Jogar);
            escolhaPicker = "Selecione o valor do dado";
            
        }

        public ICommand JogarComamand { get; private set; }

        public void Jogar()
        {
            //Sortear um dado 
            Dice dice = new Dice();
            dice.Sortear();
           // DiceImage.Source = "dado_" + dice.FaceParaCima + ".PNG";
            if (dice.FaceParaCima == SelectedValue)
            {
                Resultado = "Vitoria!!!!";
            }
            else
            {
                Resultado = "Derrota!!";
            }
            //Verificar qual face esta selecionada 
            //Verifica se o usuario escolheu certo
            //Exibir uma mensagem na tela
        }


    }
}
