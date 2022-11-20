class Program{
    static void main (string [] args){
      int num;
      int suma=0;
      int resultado=0;


      for (int n=8; n>=0; n--){
        Console.WriteLine("INTRODUCIR UN NUMERO");
        num = int.Parse(Console.ReadLine());

        resultado=suma/8;

        Console.WriteLine("LA MEDIA ARITMETICA ES: " + resultado);
      }

    }
      
}

