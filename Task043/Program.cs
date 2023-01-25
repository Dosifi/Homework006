// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int length = new Random().Next(6, 100);
int[] numbers = new int[length];

int[] FillArray(int[] array)
{
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}
void Sort(int[] array)
{
int temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}

FillArray(numbers);
Sort(numbers);