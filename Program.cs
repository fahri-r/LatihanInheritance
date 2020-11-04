using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Serigala serigala = new Serigala();
            serigala.setnama("Serigala Putih");
            serigala.getbulu();
            serigala.berjalan();
            Console.WriteLine(serigala.berbulu());
            serigala.makan();

            Console.WriteLine("");

            Serigala serigala1 = new Serigala();
            serigala1.setnama("Serigala Hitam");
            serigala1.getbulu();
            serigala1.berjalan();
            Console.WriteLine(serigala1.berbulu());
            serigala1.makan();
        }
    }
}
