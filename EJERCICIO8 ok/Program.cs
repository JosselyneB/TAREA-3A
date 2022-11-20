class Program{

     static void Main (string[]args){
        int multiploTres=0;
        int contador=0;
        
       do {
        Console.WriteLine("LOS MULTIPLOS DE 3 SON: " + multiploTres);
        multiploTres=multiploTres+3;
        contador=contador+1;
       } while (multiploTres<300);

    }
}