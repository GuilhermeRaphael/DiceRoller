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
            FaceParaCima = random.Next(6);

            if (FaceParaCima == 0)
            {
                LadoSorteado = "dado1";
            }
            else if(FaceParaCima == 1)
            {
                LadoSorteado = "dado2";
            }
            else if (FaceParaCima == 2)
            {
                LadoSorteado = "dado3";
            }
            else if (FaceParaCima == 3)
            {
                LadoSorteado = "dado4";
            }
            else if (FaceParaCima == 4)
            {
                LadoSorteado = "dado5";
            }
            else 
            {
                LadoSorteado = "dado6";
            }

            return (LadoSorteado);




        }
       
    }
}

