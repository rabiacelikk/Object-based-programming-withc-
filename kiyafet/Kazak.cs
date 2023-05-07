using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiyafet
{
    internal class Kazak : Kiyafet, IKiyafet
    {
        private string kalin;

        //değer döndürmeden yapılacak fonksiyonel işlemler gerçekleşti.
        public Kazak(string kumasTuru, string rengi, string fiyatı) : base(kumasTuru, rengi, fiyatı)
        {
            

        }

        public void KiyafetBilgileri()
        {
            base.Write();
        }

        public string OrtakKiyafet()
        {
           return base.Rengi;
        }
    }
}
