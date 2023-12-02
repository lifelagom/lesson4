// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int ReadInt(string text) {
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
// генерация массива
int[] CreateMassiv(int size) {
    int[] tempArray = new int[size];
    Random rand = new();
    for(int i = 0; i < tempArray.Length; i++) {
        tempArray[i] = rand.Next(1, 10);
    }
    return tempArray;
}
// переворот элементов массива
int[] FlipOver(int[] array) {
    int[] tempArray = new int[array.Length];
    for(int i = 0; i < tempArray.Length; i++) {
        tempArray[i] = array[array.Length-i-1];
    }
    return tempArray;
}
// основной код
int size = ReadInt("Введите размер массива: ");
int[] array = CreateMassiv(size);
Console.Write("["+string.Join(" ",array)+"] => ");
array = FlipOver(array);
Console.Write("["+string.Join(" ",array)+"]");