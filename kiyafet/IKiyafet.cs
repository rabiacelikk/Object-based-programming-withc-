using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// ınterface kullanımını burada sağladık.


namespace kiyafet
{
    internal interface IKiyafet
    {
        void KiyafetBilgileri(); // KiyafetBilgileri değişkenini çağırdım.

        string OrtakKiyafet(); // OrtakKiyafet metin içerdiği için 'string' ifadesini kullandım.
    }
}
