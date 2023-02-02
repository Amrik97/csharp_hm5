// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива
 Console.Write("Введите размер массива: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    int[] arr = new int[n];
    int maxNum = int.MinValue;
    int minNum = int.MaxValue;

    var r = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = r.Next(1, 100);
    }

    Utility.DisplayArr(arr);

    for (int i = 0; i < n; i++)
    {
        if (maxNum < arr[i]) maxNum = arr[i];
        if (minNum > arr[i]) minNum = arr[i];
    }

    Console.WriteLine($"Max: {maxNum}, Min: {minNum}, Разница: {maxNum - minNum}");