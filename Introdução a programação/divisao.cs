using System;

class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) {
            string[] line = Console.ReadLine().Split(" ");
            int X = int.Parse(line[0]);
            int Y = int.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                decimal divisao = decimal.Parse(X/Y);
                Console.WriteLine(divisao.ToString("N1"));
                
            }
        }
    }
}