using System;

namespace Esercizi{

      public class Vettore{
        private int[] array;

        public Vettore(){
            Console.WriteLine("Quanti elementi deve contenere il vettore?");
            int n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
        }

        public void SetArray(){
            Console.WriteLine("Inserire elementi per riempire il vettore: ");
            for (int i = 0; i < array.Length; i++)
            { 
                try
                {
                    Console.Write($"Elemento {i} : ");
                    int k = Convert.ToInt32(Console.ReadLine());
                    array[i] = k;
                }
                catch (Exception)
                {
                    Console.WriteLine("Non hai inserito un numero!");
                    array[i] = 0;
                }
            }
            Console.WriteLine("Vettore Caricato!");
            Console.Clear();
        }

        public void OrderArray(){
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i]>array[j]){
                        int z = array[i];
                        array[i] = array[j];
                        array[j] = z;
                    }
                }
            }
            Console.WriteLine("Vettore ordinato!");
        }

        public int[] GetArray(){    
                Console.Write("Vettore:{");
                foreach (int x in array)
                {
                    Console.Write(" " + x);
                }
                Console.Write("}\n");
                return array;
        }

        public void Search(){
            bool b = false;
            Console.Write("Inserire numero da ricercare: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                if(k == array[i]){
                    b = true;
                }
            }
            Console.WriteLine((b == true ) ? "Numero presente." : "Numero non presente.");
        }

    }


}