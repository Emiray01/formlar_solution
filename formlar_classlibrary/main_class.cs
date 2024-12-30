using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formlar_classlibrary
{
    public class main_class
    {
        public main_class()//constructor metodu(class nesnelleştiği anda çalışır)
        {

        }
        public void isim()//geri değer göndermeyen metot
        {
            
        }
        public int hesap(int x, int y)//geri değer gönderen metot 
        {
            return x * y;
        }
        public int hesap(int x, int y, int z)//overloading 
        {
            return x;
        }
        public static void isim_()//classı nesnelleştirmeden çağırılabilir(static)
        {
            
        }
    }
}
