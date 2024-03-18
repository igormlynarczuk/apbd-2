// See https://aka.ms/new-console-template for more information

Console.WriteLine("MODYFIKACJA 1");
Console.WriteLine("MODYFIKACJA 2");
Console.WriteLine("MODYFIKACJA 3");

static double average(int[] tab){
    double result=0;
    for(int i=0; i<tab.Length; i++){
        result += tab[i];
    }
    return result/tab.Length
}