class Program {
    static void Main (string [] args){
        int suma=0;

        for(int i=10000; i>=0; i--){
            Console.WriteLine("  " + i);
            suma=suma + i;
        }
        Console.WriteLine("LA SUMA ES: " + suma);

    }
}