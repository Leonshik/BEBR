using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_WORK_IGRA
{
    internal class ITEMS
    {
        public int DEF_dospeh(int p1, int SlotITEM) //ДОСПЕХ увеличивает защиту на 10
        {
            if (SlotITEM == 0)
            {
                p1 = p1 + 10;
            }
            return p1;
        }
        public int DEF_dospeh_S(int p1, int SlotITEM) //ДОСПЕХ СНИМАЕТСЯ статус слота прописывается в программ.кс
        {
            p1 = p1 - 10;
            return p1;
        }
        public int HP_amulet(int p1, int SlotITEM) //АМУЛЕТ востонавливает 2 здоровья каждый ход
        {
            if (SlotITEM == 0)
            {
                p1 = 2;
            }
            return p1;
        }
    }
}
