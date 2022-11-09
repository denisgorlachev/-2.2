//Горлачев средний уровень 
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
if ((x3 - x1) / (x2 - x1) == (y3 - y1) / (y2 - y1))
    Console.Write("точки принадлежат одной прямой");
else
    Console.Write("точки не принадлежат одной прямой");