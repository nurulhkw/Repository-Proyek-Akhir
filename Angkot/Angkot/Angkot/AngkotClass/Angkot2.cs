using System;
using System.Collections.Generic;
using System.Text;

namespace Angkot.AngkotClass
{
    public class Angkot2 : Kendaran
    {
        public override void KodeAngkot()
        {
            Console.WriteLine("Kode    : Angkot2");
        }
        public override void Jurusan()
        {
            Console.WriteLine("Jurusan : Jogja - Magelang");
        }
        public override void Operasi()
        {
            Console.WriteLine("Sedang Tidak Beroperasi ");
        }
    }
}
