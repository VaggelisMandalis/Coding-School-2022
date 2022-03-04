// See https://aka.ms/new-console-template for more information 
//-------------------------------------------1
using Session_04;

string name = "Vaggelis Mandalis";
var c1 = new Class1();
string reversedName = c1.ReverseString(name);

Console.WriteLine("The answer to the first question is : " + reversedName);


//--------------------------------------------2

Console.WriteLine("Please insert an integer");
string numberUser = Console.ReadLine();
int number2 = Convert.ToInt16(numberUser);
Console.WriteLine("Now write if you want the sum of all the number from 1 to n or 2 if you want the product");
string choiceUser = Console.ReadLine();
int choice = Convert.ToInt16(choiceUser);
var c2 = new Class2();
if (choice == 1)
{
    int sum = c2.GetSum(number2);
    Console.WriteLine("The sum is "+sum);
}
else
{
    int prod = c2.GetProduct(number2);
    Console.WriteLine("The product is "+prod);
}
//----------------------------------------------3

Console.WriteLine("\nFor the third exercise please insert an integer except 1");
int number3 = Convert.ToInt16(Console.ReadLine());
var c3 = new Class3();
c3.prime_num(number3);




//----------------------------------------------4
int[] array1 = { 2, 4, 9, 12 };
int[] array2 = { 1, 3, 7, 10 };
int[] arrayProd = new int[16];
var c4 = new Class4();
c4.MultiArrays(array1,array2,arrayProd);



//-------------------------------------------5

int[] array5 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
var c5 = new Class5();
c5.Sorting(array5);
Console.Write("\n\nThe sorted array for exercise 5 is : ");
c5.PrintSort(array5);


