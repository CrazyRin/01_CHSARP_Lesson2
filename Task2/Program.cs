int n = 10;
int[] arr_1 = new int[n];
int i = 0;

// Создаём цикл для присвоения значений элементам массива от 1 до n
//while (i < n)

// Создаём цикл для присвоения значений элементам массива от 1 до последнего индекса в массиве
while (i < arr_1.Length)
{
    arr_1[i] = i + 1;
    //Console.Write( arr_1[i]);
    //Console.Write(' ');
    Console.Write($"{arr_1[i]} ");
    i = i + 1;
}
