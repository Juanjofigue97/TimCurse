using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProteinTranslations
{
    public static class ProteinTranslation
    {
        public static string[] Proteins(string strand)
        {
            var proteinTranslations = new Dictionary<string, string>
            {
                ["Methionine"] = "AUG",
                ["Phenylalanine"] = "UUU,UUC",
                ["Leucine"] = "UUA,UUG",
                ["Serine"] = "UCU, UCC, UCA, UCG",
                ["Tyrosine"] = "UAU, UAC",
                ["Cysteine"] = "UGU, UGC",
                ["Tryptophan"] = "UGG",
                ["STOP"] = "UAA, UAG, UGA"
            };

            //List<string> list;

            //list.Add();


            throw new NotImplementedException();
        }
    }
}
