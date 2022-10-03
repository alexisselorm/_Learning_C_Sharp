// See https://aka.ms/new-console-template for more information
int[] values = new int[]{1,4,56,78,90,23};

foreach(int val in values){
     if(val <=57){
        continue;
    }
    Console.WriteLine($"val is currently {val}");

   
}