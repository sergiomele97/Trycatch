using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Worker
   {
        public Worker(string texto)
        {
            Work(texto);
        }

        public void Work(string t)
        {
            Console.WriteLine("Open file here...");

            // Aquí abrir archivo
         

            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Work\ReposSergio\Ejercicios\TryCatch\TryCatch\TextFile1.txt"))
                {
                    writer.WriteLine(t);
                    Console.WriteLine("Throwing Exception...");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Handling exception!");
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("Closing file...");

                }
                
         
         Console.WriteLine("\n\nEl programa no ha petado todavia del todo");
         Console.ReadKey();
        }
   }
}
