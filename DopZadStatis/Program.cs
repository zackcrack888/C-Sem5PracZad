﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32); 
}

void Troiki(int[] array)
{
    int tri = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==1)
            {
            tri=array[i];
            Console.Write($"{tri} ");
            }
        
    }
    
    
}

void Chetverki(int[] array)
{
    int chetire = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            {
                chetire=array[i];
                Console.Write($"{chetire} ");
            }
        
    }
    
}

void Itog(int[] array)
{
    int a = 0,b=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
            a++;
            else
            b++;
    }
    if (a>b)
    Console.Write("Yes, Vasya horoshist");
    else
    Console.Write("No, Vasya troeshnik");
}

Console.Clear();
Console.Write("Vvedite chislo mesacev: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Kol-vo ocenok po mesacam: [{string.Join(", ", array)}]");
Console.Write("Kol-vo ocenok troek po mesacam: ");
Troiki(array);
Console.WriteLine();
Console.WriteLine("Kol-vo ocenok chetverok po mesacam: ");
Chetverki(array);
Console.WriteLine();
Itog(array);