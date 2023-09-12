using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoesApp
{
    public static class Dominoes
    {
        public static bool CanChain(IEnumerable<(int, int)> dominoes)
        {
            if (!dominoes.Any()) return true;
            
            var output = false;
            dominoes = dominoes.ToList();
            var listDominoes = dominoes.ToList();
            // 1. Remove First Item
            int baseNumber = listDominoes[0].Item1;
            int firsNumber = listDominoes[0].Item2;
            listDominoes.Remove(listDominoes[0]);

            var datos = listDominoes
                .FindAll(x => x.Item1 == firsNumber || x.Item2 == firsNumber);

            Console.WriteLine(datos);

            return output;
        }

        public static List<int> SearchIndex(List<(int, int)> listDominoes, int firsNumber)
        {
            var output = new List<int>();

            for (int i = 0; i < listDominoes.Count(); i++)
            {
                if (listDominoes[i].Item1 == firsNumber && listDominoes[i].Item2 == firsNumber)
                {
                    output.Add(i);
                }
            }

            return output;
        }

        //public static bool Search(List<(int,int)>listDominoes, int baseNumber, int firsNumber)
        //{
        //    foreach (var item in listDominoes)
        //    {
        //        if (item.Item1 == baseNumber && item.Item2 == baseNumber)
        //        {
        //            listDominoes.Remove(item);
        //        }
        //        if (item.Item1 == firsNumber && item.Item2 == firsNumber)
        //        {
        //            listDominoes.Remove(item);
        //        }
        //    }
        //    for (int i = 0; i < listDominoes.Count(); i++)
        //    {
        //        int x = listDominoes[i].Item1;
        //        int y = listDominoes[i].Item2;

        //        if (x == firsNumber)
        //        {
        //            allNumbers += firsNumber.ToString() + x.ToString() + y.ToString();

        //            firsNumber = y;
        //            listDominoes.Remove(listDominoes[i]);
        //            Console.WriteLine("Numero encontrado");
        //            break;
        //        }
        //        else if (y == firsNumber)
        //        {
        //            allNumbers += firsNumber.ToString() + y.ToString() + x.ToString();

        //            firsNumber = x;
        //            Console.WriteLine("Numero encontrado");
        //            listDominoes.Remove(listDominoes[i]);
        //            break;
        //        }
        //    }
        //    if (manyItems == listDominoes.Count())
        //    {
        //        return false;
        //    }
        //}
    }
}
