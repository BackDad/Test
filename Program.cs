while(true)
{
Console.Clear();
int size = new Random().Next(3,5);
 Console.WriteLine("Создан массив размером "+ size);
 string [] ArrayOfRanum = new string [size];
FillArray(ArrayOfRanum);
PrintArray(ArrayOfRanum);
Console.Write("->");
Console.Write("[");
for(int i =0; i<SelectOfString(ArrayOfRanum).Length; i++)
    {Console.Write(SelectOfString(ArrayOfRanum)[i]);
        Console.Write(" ");
    }
Console.Write("]");
Console.WriteLine();
Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
}



// метод заполнения массива числами c клавиатуры
void FillArray(string [] collection)
{
    Console.WriteLine("Вы выбрали метод с клавиатуры");
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите {index}-й элемент массива");
        collection[index] = Console.ReadLine();
        index++;
    }
}
// метод печати массива
void PrintArray( string [] col)
{
    int index = 0;
    Console.Write("[ ");
    while (index < col.Length-1)
    {
            Console.Write(col[index]+" ,");
            index++;
    }
    Console.Write(col[index]);
    Console.Write("]");
    //Console.WriteLine();
}
// метод поиска строки с заданной длиной
string [] SelectOfString(string []array)
{
int index = 0;
int k =0;
string [] newArray = new string [array.Length];
while( index < array.Length)
{
    if (array[index].Length <=3)
    {
        newArray[k]=array[index];
        k++;
        index++;
    }
    else index++;
}
return newArray;
}