using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiyafet
{
    internal class Pantolon : Kiyafet,IKiyafet
    // atadığım bütün değerleri türleri ile birliklte public Pantolon kısmının içerisine yazdım(pantolon ile ortak olan kısım).

    {
        private bool uzun;  
        public Pantolon(string kumasTuru, string rengi, string fiyatı, bool uzun) : base(kumasTuru, rengi, fiyatı)
        {
        this.uzun = uzun;
        }


        //değer döndürmeden yapılacak fonksiyonel işlemler gerçekleşti.
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
