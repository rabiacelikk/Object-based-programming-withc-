using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kiyafet
{
    internal sealed class KiyafetYonetimi
    {
        List<Kazak> kazaklar=new List<Kazak>();
        List<Pantolon> pantolonlar=new List<Pantolon>();

        public KiyafetYonetimi() 
        { 
        }

        public KiyafetYonetimi(Kazak kazak)
        {
            Add(kazak);
        }
        public KiyafetYonetimi(Pantolon pantolon)
        {
            Add(pantolon);
        }
        public void Add(Kazak kazak)
        {
            kazaklar.Add(kazak);
        }
        public void Add(Pantolon pantolon)
        {
            pantolonlar.Add(pantolon);
        }
        
        // Bilgileri yazdırmak için oluşturulan kod.
        public void WriteKazakInfo()
        {
          
                foreach ( var item in kazaklar)
                {
                item.KiyafetBilgileri();
                }
        }
       
        public void WritePantolonInfo()
        {
            foreach ( var item in pantolonlar)
            {
                item.KiyafetBilgileri();
            }
        }
    }
}
