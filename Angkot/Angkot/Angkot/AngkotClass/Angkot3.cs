using System;
using System.Collections.Generic;
using System.Text;

namespace Angkot.AngkotClass
{
    public class Angkot3 : Kendaran
    {
        public override void KodeAngkot()
        {
            Console.WriteLine("Kode    : Angkot3");
        }
        public override void Jurusan()
        {
            Console.WriteLine("Jurusan : Jogja - Solo");
        }
        public override void Operasi()
        {
            Console.WriteLine("Sedang beroperasi ");
        }
    }
}
