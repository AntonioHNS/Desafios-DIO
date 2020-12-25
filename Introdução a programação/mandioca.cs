using System;
class Desafio {
    static void Main() {
        Int32 chico = 300 * Int32.Parse(Console.ReadLine());
        Int32 bento = 1500 * Int32.Parse(Console.ReadLine());
        Int32 bernardo = 600 * Int32.Parse(Console.ReadLine());
        Int32 marina = 1000 * Int32.Parse(Console.ReadLine());
        Int32 iara = 150 * Int32.Parse(Console.ReadLine());
        Int32 marlene = 225;
        Int32 total = marlene+iara+marina+bernardo+bento+chico; // Digite aqui o calculo total
        Console.WriteLine(total.ToString());
    }
}