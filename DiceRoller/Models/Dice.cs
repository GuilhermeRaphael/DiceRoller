using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Dice
    {

        //property
        public string LadoSorteado;
        public int FaceParaCima;
        public int FaceParaBaixo;
        public int QuantidadeDeFaces;

        //add agora
        public Dice()
        {
            QuantidadeDeFaces = 6;
        }
        //add agora
        public Dice(int faces)
        {
            QuantidadeDeFaces = faces;
        }

        public string Roller(int pickerSelect)
        {
            Random random = new Random();
            // FaceParaCima = random.Next(1, 7);
            FaceParaCima = random.Next(1, QuantidadeDeFaces + 1); //add agora

            // FaceParaBaixo = 7 - FaceParaCima;
            FaceParaBaixo = 1 + QuantidadeDeFaces - FaceParaCima;



            if (FaceParaCima == pickerSelect)
            {
                LadoSorteado = "Você acertou!";
            }
            else
            {
                LadoSorteado = "Você errou!";
            }

            return LadoSorteado;
        }
    }
}