using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// az adatok.txt fájl 20 egész számot tartalmaz
// külön sorban.
// Olvassuk be a számokat egy tömbbe.
//  - változó amibe a számokat eltároljuk (egész, tömb, 20)
//  - Fájlművlet -> System.IO;
//  - Fájlkezelés -> StreamReader
//  - Beolvasás
//      - Ciklus -> for (tudjuk a mennyiséget!)
//            - egy sort beolvasunk
//            - konvertálás egész számmá
//            - eltárolás a tömbben
//  - Lezárás (ne maradjon nyitva erőforrás)
// Írassuk ki az összegüket.
// Írassuk ki a legnagyobb és legkisebb számot
// amit a tömb tartalmaz.

namespace TetelekFajlbol
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[20];
      StreamReader file = new StreamReader("adatok.txt");

      for (int i = 0; i < tomb.Length; i++)
      {
        string sor = file.ReadLine(); // sor = "12" szöveg!
        int szam = Convert.ToInt32(sor);
        tomb[i] = szam;
      }

      file.Close();

      // A tömbben lévő számok összegének kiszámolása
      // majd a kiíratása (Összegzés tétele)
      int szum = 0;
      for (int i = 0; i < tomb.Length; i++)
      {
        szum = szum + tomb[i];
        // szum += tomb[i];
      }
      Console.WriteLine("A számok összege: {0}",szum);

      // A tíznél nagyobb számok összege?
      int tiznel = 0;
      for (int i = 0; i < tomb.Length; i++)
      {
        if (tomb[i] > 10)
        {
          tiznel += tomb[i];
        }
      }
      Console.WriteLine("A tíznél nagyob számok összege: {0}",tiznel);

      // Minden második számot adjunk össze, írassuk ki
      // Az első a 0. indexű szám
      szum = 0;
      for (int i = 0; i < tomb.Length; i = i + 2)
      {
        szum += tomb[i];
      }
      Console.WriteLine("Minden második elem összege: {0}", szum);

      szum = 0;
      int j = 0;
      while (j < tomb.Length)
      {
        szum += tomb[j];
        j += 2;
      }
      Console.WriteLine("Minden második összege: {0} (while).",szum);

      // Írjuk ki az elemeket fordított sorrendben!
      for (int i = 19;i >= 0 ; i--)
      {
        Console.WriteLine(tomb[i]);
      }

      j = 19;
      while (j >= 0)
      {
        Console.WriteLine(tomb[j--]);
        // j--;
      }


      Console.ReadKey();
    }
  }
}
