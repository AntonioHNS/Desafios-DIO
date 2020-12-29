using System;

class Desafio {
    static void Main() {
        int R = Int32.Parse(Console.ReadLine());
        int V = Int32.Parse(Console.ReadLine());
        while (V < R){
          V = Int32.Parse(Console.ReadLine());
        }
        int N = 1;
        int Rteste = R;
        while (Rteste <= V){
          Rteste = Rteste+R+N;
          N++;
        }
        Console.WriteLine(N);
        
    }
}