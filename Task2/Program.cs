// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int ReadInt(string text) {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// генерация массива
int[] CreateMassiv(int size) {
    int[] tempArray = new int[size];
    Random rand = new();
    for(int i = 0; i < tempArray.Length; i++) {
        tempArray[i] = rand.Next(100, 1000);
    }
    return tempArray;
}
// проверка чисел на четность
int CheckOnChet(int[] tempArray) {
    int count = 0;
    for(int i = 0; i < tempArray.Length; i++) {
        if (tempArray[i]%2==0) {
            count++;
        }   
    }     
    return count;
}
// основной код
int size = ReadInt("Введите размер массива: ");
int[] array = CreateMassiv(size);
int count = CheckOnChet(array);
Console.WriteLine("["+string.Join(" ",array)+"] => "+count);