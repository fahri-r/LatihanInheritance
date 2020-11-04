using System;

namespace LatihanInheritance
{
    class Hewan{
        string nama = null;
        public string bulu = "";
        public string hewan = "Saya Hewan ";

        public void setnama(string s){
            nama = s ;
            Console.WriteLine("Saya bernama " + nama);
        }

        public void getbulu(){
            bulu = nama.Substring(9);
        }

        public string berjalan(){
            return nama + " Berjalan";
        }
    }
}
