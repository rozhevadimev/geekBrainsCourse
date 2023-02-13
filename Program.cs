// Задание со *. Задать массив случайных чисел и 
//отсортировать его методом пузырька по убыванию.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
return result;
}

int[]array = GetArray(12, -110,110);

Console.WriteLine(String.Join(", ", array));
for (int i = 0; i < array.Length - 1; i++)
 for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
               array[j] = array[j + 1];
               array[j + 1] = temp;
            }
        }
        Console.WriteLine(String.Join(", ", array));
