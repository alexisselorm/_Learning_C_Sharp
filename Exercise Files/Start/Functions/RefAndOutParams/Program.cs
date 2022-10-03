// See https://aka.ms/new-console-template for more information

int age = 45;

Console.WriteLine(age);

void TestFunc(ref int val){
    age = 25;
    Console.WriteLine(val);
}
TestFunc(ref age);
Console.WriteLine(age);

// out keyword
static void PlusTimes(int arg1,int arg2,out int sum,out int product){
    sum = arg1+arg2;
    product = arg1*arg2;
}
int a,b;
int month = 4;
PlusTimes(age,month,out a,out b);
Console.WriteLine($"{a} {b}");