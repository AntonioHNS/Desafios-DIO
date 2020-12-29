using System;

class Desafio {
    static void Main() {
        
        int entradas = 3;
        
        for (int i = 0; i<3; i++){
          int qtdTartarugas = Int32.Parse(Console.ReadLine());
          string[] velocidades = Console.ReadLine().Split(' ');
          int maiorVelocidade = 0;
          for (int tartaruga = 0; tartaruga < qtdTartarugas;tartaruga++ ){
            if (Int32.Parse(velocidades[tartaruga]) > maiorVelocidade){
              maiorVelocidade = Int32.Parse(velocidades[tartaruga]);
            }
          }
          if(maiorVelocidade<10){
            Console.WriteLine('1');
          } else if (maiorVelocidade>=10 && maiorVelocidade<20){
            Console.WriteLine('2');
          } else if (maiorVelocidade>=20){
            Console.WriteLine('3');
          }
          
        }
        
    }
}