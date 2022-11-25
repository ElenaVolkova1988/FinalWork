// Написать программу, котрая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
string [ ] CreateArray (int size)
{
  string [] array = new string[size];
      for(int i=0; i< size ; i++)
{
      Console.Write($"Input a {i+1} element of array: ");
      array [i]= Convert.ToString(Console.ReadLine());
}
         return array;
} 
void ShowArray (string []array) 
 {
    for( int i=0; i< array.Length; i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
 }

string [] ThreeCharacters ( string [] array)
{
    string [] finalArray = new string [array.Length];
    int count = 0;
    for (int i = 0; i < finalArray.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            finalArray[count] = array[i];
            count++;
        }
    }
    return finalArray;
}

Console.WriteLine("Input size array :");
int size= Convert.ToInt32(Console.ReadLine());
string [] myArray = CreateArray(size);
ShowArray(myArray);
string [] newArray=ThreeCharacters(myArray);
ShowArray(newArray);

