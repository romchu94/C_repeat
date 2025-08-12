﻿// Дан текст. В тексте нужно все пробела заменить черточками, маленькие буквы "к" заменить
// большими "К", а большие "В" заменить маленькими "в".

string text = "- Я думаю, сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "Вы бы взяли приступом согласие прусского короля. ";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);


// Отсортировать массив по возрастанию
