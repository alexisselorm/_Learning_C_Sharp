// See https://aka.ms/new-console-template for more information
int x = 2500;
int y = 2;

int result;

// TODO: try-catch expressions make error checking easier 
try{
    if(x > 1000){
        throw new ArgumentOutOfRangeException("x","x has to be 1000 or less");
    }
    result = x / y;
Console.WriteLine("The result is: {0}",result);
}catch(DivideByZeroException e){
    Console.WriteLine("Whoops");
    Console.WriteLine(e.Message);
}catch(ArgumentOutOfRangeException e){
Console.WriteLine("1000 is the limit");
Console.WriteLine(e.Message);
}finally{
    Console.WriteLine("This is always going to run, exceptions or not");
}
