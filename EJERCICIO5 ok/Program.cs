class Program {
    static void Main (string [] args){
        int num;
        int suma=0;

        for(int i=1; i<=8; i++){
            Console.WriteLine("INTRODUCIR UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
            suma=suma + num;
        }
        Console.WriteLine("LA SUMA ES: " + suma);
    }
}