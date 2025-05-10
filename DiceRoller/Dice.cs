using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        private string ladoSorteado;
        private int faceParaCima;
        private int faceParaBaixo;

        public string LadoSorteado { get => ladoSorteado; set => ladoSorteado = value; }
        public int FaceParaCima { get => faceParaCima; set => faceParaCima = value; }
        public int FaceParaBaixo { get => faceParaBaixo; set => faceParaBaixo = value; }


        public Dice()
        {
           
        }

        public string Roller(int pickerSelect)
        {
            Random random = new Random();
            FaceParaCima = random.Next(1, 7);
            FaceParaBaixo = 7 - FaceParaCima;

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