Console.Clear();		// очистка экрана
int xa = 40, ya = 1,		// определяем вершины треугольника
     xb = 1, yb = 30,
     xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);	// Постановка курсора в нужную позицию
Console.WriteLine("+"); // Вывод выбранной позиции

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;	// Определение случайной точки x

int count = 0;

while(count < 10000)
{
	int what = new Random().Next(0, 3);	// Сгенерируем случайное число [0;3) в интервале от 3, ограничение 3. т.е. выбор между числами 0,1,2
	if(what == 0) // Проверка
	{
	x = (x + xa)/2;		// Присвоим x середину отрезка
	y = (y + ya)/2;
}
if(what == 1) // Проверка
	{
	x = (x + xb)/2;		
	y = (y + yb)/2;
}
if(what == 2) // Проверка
	{
	x = (x + xc)/2;		
	y = (y + yc)/2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;	// или +=1
}
