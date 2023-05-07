namespace kiyafet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiyafetYonetimi kiyafet = new KiyafetYonetimi();
            // kazak değerimin özelliklerini (k1, k2, k3, k4) tanımladım.( bool ve string değerler girildi)
            
            Kazak k1 = new Kazak("poplin", "kırmızı","650");
            Kazak k2 = new Kazak("kadife", "mavi", "501");
            Kazak k3 = new Kazak("ipek", "sarı", "605");
            Kazak k4 = new Kazak("pamuk", "yeşil", "802");

            //pantolon değerimin özelliklerini ( p2, p3, p4, p5) tanımladım.( bool ve string değerler girildi)

            Pantolon p2 = new Pantolon("jean", "mavi", "500", true);
            Pantolon p3 = new Pantolon("kadife", "bordo", "645", false);
            Pantolon p4 = new Pantolon("müslin", "mavi", "550", true);
            Pantolon p5 = new Pantolon("polyester", "sarı", "350", true);

                // kiyafet'e k1, k2, k3, k4'ü ekledim. 
            kiyafet.Add(k1);
            kiyafet.Add(k2);
            kiyafet.Add(k3);
            kiyafet.Add(k4);

            // kiyafet'e p2, p3, p4, p5'i ekledim.

            kiyafet.Add(p2);
            kiyafet.Add(p3);    
            kiyafet.Add(p4);
            kiyafet.Add(p5);

            kiyafet.WriteKazakInfo();
            kiyafet.WritePantolonInfo();
            Console.ReadKey();








        }
    }
}