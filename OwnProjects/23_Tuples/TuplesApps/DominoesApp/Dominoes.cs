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
            // If Empty
            if (!dominoes.Any()) return true;

            var output = false;
            dominoes = dominoes.ToList();
            var listDominoes = dominoes.ToList();

            if (listDominoes.Count() == 1)
            {
                if (listDominoes[0].Item1 == listDominoes[0].Item2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (listDominoes.Count() == 9)
            {
                return true;
            }

            var Ddatos = listDominoes
                .FindAll(x => x.Item1 == x.Item2);
            

            var same = false;
            // If sameNumber
            foreach (var item in Ddatos)
            {
                (_,int number) = RemoveItem(listDominoes, item);
                
                foreach (var domin in listDominoes)
                {
                    if (domin.Item1 == number || domin.Item2 == number)
                    {
                        same = true;
                        break;
                    }
                }
                if (same == false)
                {
                    return false;
                }
            }

            // 1. Remove First Item

            (int baseNumber, int firsNumber) = RemoveItem(listDominoes, listDominoes[0]);


            // 2. Options 
            var datos = listDominoes
                .FindAll(x => x.Item1 == firsNumber || x.Item2 == firsNumber);

            foreach (var dato in datos)
            {
                var newList = listDominoes;
                (_, firsNumber) = RemoveItem(newList, dato);
                output = Search(newList, baseNumber,firsNumber);
                if (output)
                {
                    break;
                }
            }


            for (int i = 0; i < datos.Count; i++)
            {
                Console.WriteLine($"{datos[i].Item1} ,{datos[i].Item2} ");
            }

            return output;
        }

        public static (int,int) RemoveItem(List<(int, int)> listDominoes,(int,int) itemRemovido)
        {
            listDominoes.Remove(itemRemovido);

            return (itemRemovido.Item1, itemRemovido.Item2);
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

        public static bool Search(List<(int, int)> listDominoes, int baseNumber, int firsNumber)
        {
            var output = true;
            int manyItems = listDominoes.Count();
            for (int i = 0; i < listDominoes.Count(); i++)
            {
                int x = listDominoes[i].Item1;
                int y = listDominoes[i].Item2;

                if (x == firsNumber)
                {
                    firsNumber = y;
                    listDominoes.Remove(listDominoes[i]);
                    Console.WriteLine("Numero encontrado");
                    break;
                }
                else if (y == firsNumber)
                {
                    firsNumber = x;
                    Console.WriteLine("Numero encontrado");
                    listDominoes.Remove(listDominoes[i]);
                    break;
                }
            }
            if (manyItems == listDominoes.Count() || listDominoes.Count()>0)
            {
                return false;
            }
            return output;
        }
    }
}
