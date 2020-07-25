using System;
using System.Collections.Generic;
using System.Text;

namespace Angkot.AngkotClass
{
    public class Angkot1 : Kendaran
    {
        public override void KodeAngkot()
        {
            Console.WriteLine("Kode    : Angkot1");
        }
        public override void Jurusan()
        {
            Console.WriteLine("Jurusan : Jogja - Magelang");
        }
        public override void Operasi()
        {
            Console.WriteLine("Sedang beroperasi ");
        }        
    }
}
