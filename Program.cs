//Функция для подсчета кол-ва элементов с длинной <= 3
using System.Globalization;

int CountElements(string[] data)
{
    int count = 0;
    for (int i = 0; i < data.Length; i++)// перебираем каждый элемент массива
    {
        if (data[i].Length <= 3) //Проверяем длинну строки
        {
            count ++;
        }
    }
    return count; //Возвращаем кол-во элементов, удовлетворяющие условию
}

void PrintMas(string[] mas)
{
    Console.WriteLine($"[{String.Join("; ", mas)}]");
}

string[] CreateNewMas(string[] data)
{
    string[] temp = new string[CountElements(data)];
    int j = 0;
    for (int i = 0; i < data.Length; i++)// перебираем каждый элемент массива
    {
        if (data[i].Length <= 3) //Проверяем длинну строки
        {
            temp[j] = data[i];
            j ++;
        }
    }
    return temp;
}
string[] mas = {"Hello", "2", "world", ":-)"}; //Искомый массив. Варианты {"Hello", "2", "world", ":-)"} {"Russia", "Denmark", "Kazan"} {"1234", "1567", "-2", "computer science"}

PrintMas(mas);
string[] res = CreateNewMas(mas); //Итоговый массив
PrintMas(res);



