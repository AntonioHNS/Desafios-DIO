using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  
  static void Main(string[] args) {
    
    List<string> listaJoias = new List<string>();
    string joia = Console.ReadLine();  
      
    while(!string.IsNullOrWhiteSpace(joia)){
      listaJoias.Add(joia);
      joia = Console.ReadLine();
    }
    Console.WriteLine(listaJoias.Distinct().Count());
  }

}