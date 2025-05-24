using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    public class Sequencia
    {

        private int playerPoint = 0;
        private int streak = 0;

        public int PlayerPoint { get => playerPoint; set => playerPoint = value; }
        public int Streak { get => streak; set => streak = value; }


        public bool CheckWinner(int LadoSorteado, int ladoEscolhido)
        {
            if (LadoSorteado == ladoEscolhido)
            {
                PlayerPoint++;
                Streak++;
                return true;
            }
            else
            {
                Streak = 0;
                return false;
            }

        }


    }
}