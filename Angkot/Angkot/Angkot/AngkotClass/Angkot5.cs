using System;
using System.Collections.Generic;
using System.Text;

namespace Angkot.AngkotClass
{
    public class Angkot5 : Kendaran
    {
        public override void KodeAngkot()
        {
            Console.WriteLine("Kode    : Angkot5");
        }
        public override void Jurusan()
        {
            Console.WriteLine("Jurusan : Jogja - solo");
        }
        public override void Operasi()
        {
            Console.WriteLine("Sedang beroperasi ");
        }
    }
}
