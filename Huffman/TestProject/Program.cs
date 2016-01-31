using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuffmanLibrary;
using System.Runtime.Serialization;
using System.Xml;

namespace TestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Huffman huf = new Huffman("acccbbdde");
            Console.WriteLine(huf.Encode("abc"));
            Console.WriteLine(huf.Decode(huf.Encode("abc")));
            Console.ReadKey();
        }
    }
}
