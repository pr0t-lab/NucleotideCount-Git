using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NucleotideCount_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            NucleotideCount nc = new NucleotideCount("G");

            Console.ReadLine();
        } // end of Main method

	} // end of Program class
	
    public class NucleotideCount
    {
        char[] array = { 'A', 'C', 'G', 'T' }; 
        string _sequence;
        Dictionary<char, int> _nucleotides;

        public NucleotideCount(string sequence)
        {
            if (!string.IsNullOrEmpty(sequence) && !sequence.All(n => n == array[0] || n == array[1] || n == array[2] || n == array[3]))
                throw new InvalidNucleotideException();

            _sequence = sequence.ToUpper();
        }

        public IDictionary<char, int> NucleotideCounts
        {
            get
            {
                _nucleotides = new Dictionary<char, int>();
                foreach(char n in array)
                    _nucleotides.Add(n, _sequence.Where(c => c == n).Count());

                return _nucleotides;
            }
        }
    } // end of NucleotideCount class

    public class InvalidNucleotideException : Exception { }	
} // end of NucleotideCount_Git namespace
