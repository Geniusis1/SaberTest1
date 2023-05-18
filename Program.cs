using System.Text;

/* 
 * Белокуров Владимир Владимировчи
 * Дата выполнения: 18.05.2023
 * Примерное время на тест: < 60 минут
 */

void ToBinary(int number)
{
    // Проверка на ноль
    if (number == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        // Определение знака числа
        bool isNegative = number < 0;
        if (isNegative)
        {
            // Преобразование отрицательного числа в его положительное представление
            number = -number;
        }

        // Конвертация числа в двоичное представление
        string binaryString = "";
        while (number > 0)
        {
            // Получение остатка от деления на 2
            int remainder = number % 2;

            // Добавление остатка в начало строки
            binaryString = remainder.ToString() + binaryString;

            // Деление числа на 2
            number /= 2;
        }

        // Добавление знака минуса, если число отрицательное
        if (isNegative)
        {
            binaryString = "-" + binaryString;
        }

        Console.WriteLine(binaryString);
    }
}

void RemoveDups(StringBuilder str)
{
    int length = str.Length;

    if (length < 2)
    {
        return; // Если строка пустая или содержит только один символ, нет дубликатов для удаления
    }

    int slow = 0; // Указатель на текущую позицию для записи
    int fast = 1; // Указатель на текущую позицию для чтения

    while (fast < length)
    {
        if (str[slow] == str[fast])
        {
            fast++; // Пропустить дубликаты
        }
        else
        {
            slow++; // Переместиться на следующую позицию для записи
            str[slow] = str[fast]; // Скопировать символ
            fast++; // Переместиться на следующую позицию для чтения
        }
    }

    // Удалить оставшуюся часть строки
    str.Length = slow + 1;
}

ToBinary(0);    //0
ToBinary(20);   //10100
ToBinary(-57);  //-111001

var data = new StringBuilder("WsSsssKll--13233");
RemoveDups(data);
Console.WriteLine(data); //WsSsKl-1323