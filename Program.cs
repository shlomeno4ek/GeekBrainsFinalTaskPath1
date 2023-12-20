//Функция для подсчета кол-ва элементов с длинной <= 3
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

string[] mas = {"Russia", "Denmark", "Kazan"};
string[] res = new string[CountElements(mas)];

