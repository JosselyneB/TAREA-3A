internal class NewBaseType
{
    static void Main(string[] args){

        Console.WriteLine("Ingrese el primer numero");
        int num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int num2=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero");
        int num3=int.Parse(Console.ReadLine());

        if((num1>num2 && num1>num3)){
             Console.WriteLine("EL NUMERO MAYOR ES: " + num1);
        }
        else if(num2>num1 && num2 > num3){
                 Console.WriteLine("ES NUMERO MAYOR ES: " + num2);
          }else
                   Console.WriteLine("EL NUMERO MAYOR ES: " + num3);

    }

}