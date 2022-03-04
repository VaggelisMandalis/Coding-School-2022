// See https://aka.ms/new-console-template for more information 
//-------------------------------------------1
string name = "Vaggelis Mandalis";
int length = name.Length - 1;
string reverseName = string.Empty;
while (length >= 0) {

    reverseName = reverseName + name[length];
    length--;
}
Console.WriteLine("The answer to the first question is : " + reverseName);


//--------------------------------------------2

Console.WriteLine("Please insert an integer");
string numberUser = Console.ReadLine();
int number2 = Convert.ToInt16(numberUser);
Console.WriteLine("Now write if you want the sum of all the number from 1 to n or 2 if you want the product");
string choiceUser = Console.ReadLine();
int choice = Convert.ToInt16(choiceUser);
if (choice == 1)
{
    int sum=0;
    for (int i = 1; i <= number2; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine("The sum is "+sum);
}
else
{
    int prod = 1;
    for (int i = 1; i <= number2; i++)
    {
        prod = prod * i;
    }
    Console.WriteLine("The product is "+prod);
}

//----------------------------------------------4
int[] array1 = { 2, 4, 9, 12 };
int[] array2 = { 1, 3, 7, 10 };
int[] arrayProd = new int[16];
Console.WriteLine("The number of the new array for the 4th exercise are : ");
for (int i = 0; i < 4; i++)
{
    for (int k = 0; k < 4; k++)
    {
        arrayProd[i + k] = array1[i] * array2[k];
        Console.Write(" "+arrayProd[i+ k]);
    }
}

//----------------------------------------------3

Console.WriteLine("\nFor the third exercise please insert an integer except 1");
int number3 = Convert.ToInt16(Console.ReadLine());
prime_num(number3);

void  prime_num(int num)
{

    for (int i = 2; i <= num; i++)
    {
        int counter = 0;
        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                counter++;
                break;
            }
        }

        if (counter == 0 && i != 1)
        {
            Console.Write("{0} ", i);
        }
    }
}

//-------------------------------------------5

int[] array5 = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
for (int m = 0; m < array5.Length; m++)
{
    for (int n = 0; n < array5.Length - 1; n++)
    {
        if (array5[n] > array5[n + 1])
        {
            int temp = array5[n];
            array5[n] = array5[n + 1];
            array5[n + 1] = temp;
        }
    }
}
Console.Write("The sorted array for exercise 5 is : ");
for (int m = 0; m < array5.Length; m++)
{
    Console.Write(array5[m] + " ");
}
