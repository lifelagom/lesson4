// Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.

string ReadStr(string text) {
    System.Console.Write(text);
    return Console.ReadLine();
}
// проверка суммы цифр на чётность
bool CheckSumChet(string temp) {
    bool end = false;
    int sum = 0;
    for(int i = 0; i<temp.Length; i++) {
        sum += Convert.ToInt32(temp[i]);
    }
    if (sum%2==0) {
        end = true;
    }    
    return end;
}
// проверка ввода символа ‘q’
bool CheckEnd(string temp) {
    bool end = true;
    if ((temp == "q")||(CheckSumChet(temp))) {
        end = false;
    }
    return end;
}

// основная программа
string text = string.Empty;
string temp;
do {
    temp = ReadStr("Введите целое число: ");
    text += temp+" ";
} while (CheckEnd(temp));
text += "[STOP]";
Console.WriteLine(text);