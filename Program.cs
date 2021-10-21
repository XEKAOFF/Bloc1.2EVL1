using System;

namespace CX657
{
    class Program
    {
        static void Main(string[] args)
        {


            int dessous = 0;
            int dessus = 0;
            float note = 0;

            for (int i = 0; i < 10; i++)
            {



                Console.WriteLine("mettez votre note");
                bool ok = false; 
                while (!ok)
                {


            try
                  {
                    note = float.Parse(Console.ReadLine());
                   ok = true; 
                  }
                  catch (Exception ex)
                  {
                   Console.WriteLine("selectioné un nombre valide");
                  }
                    if (note >= 10)
                    {
                        dessus = +1;
                    }

                    if (note < 10)
                    {
                        dessous = +1;
                    }



                }

             }

            Console.WriteLine("il y'a " + dessous + "note en dessous de 10");
                Console.WriteLine("il y'a" + dessus + "note en dessus de 10");
            

        }
    }
}
