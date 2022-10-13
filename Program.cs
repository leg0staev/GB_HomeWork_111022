
Console.WriteLine("======= ЗАДАЧА 25 ========");
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("введите 2 числа A и В, и я возведу число А в натуральную степень В");
Console.WriteLine("число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 0){
    Console.WriteLine($"Натуральная степень это когда она больше 0, пожалуйста ввдеите B > 0");
}
else{
    Console.WriteLine($"Если возвести {a} степень {b}, то получится => {Degree(a, b)}");
}
    
int Degree(int a, int b){

    int result = 1;
    for (int i = 0; i < b; i++){
    result *= a;
    }
    return result;
    }

Console.WriteLine("======= ЗАДАЧА 27 ========");
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите любое число, и я сосчитаю сумму цифр из которых оно состоит: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма всех цифр в числе равна => {DigitsSum(number)}");


int DigitsSum(int number){
    int result = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        number = number / 10;
        result = result + lastDigit;
    }
    return result;
}

Console.WriteLine("======= ЗАДАЧА 27 ========");
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] array = GetBinaryArray(8);

int[] GetBinaryArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next (0, 10);
    }
    return result;
}

Console.WriteLine($"[{String.Join(",", array)}]");



