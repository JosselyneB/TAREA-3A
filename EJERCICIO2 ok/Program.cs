class Program
{
    public static void Main(string[] args){
      int num=0;
       int par, impar;


        Console.WriteLine("ingrese un numero");
        num=int.Parse(Console.ReadLine());
        if(num%2==0)
        {
          Console.WriteLine("par");
        }
        else
        {
         Console.WriteLine("impar");
        }
    
        }
}