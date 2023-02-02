// Написать программу масштабирования фигуры

Console.Write("Введите вершины фигуры: ");
    var split = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Console.Write("Введите коэф: ");
    var k = double.Parse(Console.ReadLine()!);

    var coords = new (double, double)[split.Length];

    for (int i = 0; i < split.Length; i++)
    {
        var point = split[i].Split(new char[] { '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);
        coords[i] = (double.Parse(point[0]), double.Parse(point[1]));
    }

    for (int i = 0; i < coords.Length; i++)
    {
        coords[i].Item1 *= k;
        coords[i].Item2 *= k;
    }

    for (int i = 0; i < coords.Length; i++)
    {
        Console.Write($"({coords[i].Item1},{coords[i].Item2})");
    }

    Console.WriteLine();