using System;
using System.Collections.Generic;
using System.Text;

namespace Angkot.AngkotClass
{
    public class Angkot4 : Kendaran
    {
        public override void KodeAngkot()
        {
            Console.WriteLine("Kode    : Angkot4");
        }
        public override void Jurusan()
        {
            Console.WriteLine("Jurusan : Jogja - Wonosobo");
        }
        public override void Operasi()
        {
            Console.WriteLine("Sedang Dalam Perbaikan ");
        }
    }
}
