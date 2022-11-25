// Написать программу, котрая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
string [ ] CreateArray (int size)
{
    
    string [] myArray=new string [size];

    for (int i= 0; i<myArray.Length; i++)
    {
        Console.WriteLine("Input information :");
        myArray[i]=Console.ReadLine();
    }
    return myArray;
}

Console.WriteLine("Input size array :");
int size= Convert.ToInt32(Console.ReadLine());
string [] myArray = CreateArray(size);

