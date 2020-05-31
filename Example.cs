using System;

namespace Esercizi
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuoi creare il vettore?[S/N]");
            string s = Console.ReadLine();
            if(s == "S" || s == "s"){
                Vettore v = new Vettore();
                v.SetArray();
                Scelta(v);
            }else if(s == "N" || s == "n"){
                Console.WriteLine("Programma Terminato!");
            }
        }

        static void Scelta(Vettore v){
            int n;
            string [] m = new string[] {"Digita 1 per ordinare il vettore","Digita 2 per stampare il vettore","Digita 3 per cercare un elemento nel vettore","Digita 4 per uscire dal programma"};

                try
                {
                foreach (string s in m){Console.WriteLine(s);}

                n = Convert.ToInt32(Console.ReadLine());

                switch(n){
                case 1:
                    v.OrderArray();
                break;
                case 2:
                    v.GetArray();
                break;
                case 3: 
                    v.Search();
                break;
                case 4:
                    Console.WriteLine("Ciao!");
                break;
                } 
                if(n == 4){
                    //Termina programma
                }else{
                    Console.WriteLine("Effettuare un'altra operazione?[S/N]");
                    string t = Console.ReadLine();
                    if(t == "S" || t == "s"){
                        Console.Clear();
                        Scelta(v);
                    }
                }   
                }
                catch (Exception)
                {
                  Console.WriteLine("Scelta non valida.Riprovare?[S/N]");
                  string k = Console.ReadLine();
                  if(k == "S"||k == "s"){
                      Console.Clear();
                      Scelta(v);
                  }else{
                    Console.WriteLine("Programma Terminato!");
                  }
                }               
        }
    }
    
}
