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
        } // end of Main method
	} // end of Program class
	
public class NucleotideCount
{
    public NucleotideCount(string sequence)
    {
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
} // end of NucleotideCount class

public class InvalidNucleotideException : Exception { }	
} // end of NucleotideCount_Git namespace
