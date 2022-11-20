class Program
{
    static void Main(string[] args)
    {
        double ld1, ld2, ld3;
        string respuesta;

        Console.WriteLine("INGRESE EL PRIMER LADO:");
        ld1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE EL SEGUNDO LADO:");
        ld2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("INGRESE EL TERCER LADO:");
        ld3 = Convert.ToDouble(Console.ReadLine());

        do{
            
            if (ld1 == ld2 && ld1==ld3)
            Console.WriteLine("es equilatero");
            else    
             {
            if (ld1== ld2 ||ld1 ==ld3 || ld3==ld2)
                Console.WriteLine("es isosceles");
            else
            {
                if (ld1 != ld2 || ld2!=ld3 || ld3 != ld1)
                    Console.WriteLine("es escaleno");
               }    
            }
        

        Console.WriteLine("¿QUIERE CONTINUAR? s SI n NO" );
        respuesta=Console.ReadLine();
        }while(respuesta.Equals("s"));

    }
}
