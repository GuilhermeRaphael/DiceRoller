using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage; //colocar a primeira letra em minusculo

        [ObservableProperty]
        private string nomeUsuario;

        GameViewModel() {

            DiceImage = "dicel.png";
            NomeUsuario = "Eu";
        }
    }
}
