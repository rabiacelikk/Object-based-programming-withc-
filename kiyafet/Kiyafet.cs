using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kiyafet
{
    //abstract class, ögeleri gizleyerek sadece sınıfın sahip olduğu özellikleri gösterdim.
    public abstract class Kiyafet
    {
        private string kumasTuru; // burada kumasTuru, rengi, fiyatı şeklinde 3 adet private tanımladım.
        private string rengi;
        private string fiyatı;

        public Kiyafet(string kumasTuru, string rengi, string fiyatı)
        {
            this.kumasTuru = kumasTuru; // this sayesinde içinde bulunduğu nesneyi referans göstererek tanımladım.Bu sayede nesnelere ait özelliklere erişim sağladım.
            this.rengi = rengi; 
            this.fiyatı = fiyatı;
    }
        protected string Rengi { get => rengi; } // kapsülleme yaparak değer okuma işlemi (get metodu) kullandım.
        protected void Write() 
       

         // Ekran çıktılarımı yazdırdım. 
        
        { 
            
            string value = $"----{Environment.NewLine}  Fiyatı: {fiyatı+Environment.NewLine} Rengi:{rengi+Environment.NewLine} Kumaş Türü:{kumasTuru}" ;
            Console.WriteLine(value);
        }
    }

}























































































































