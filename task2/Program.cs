// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONCTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 0;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidataLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[COEFFICIENT]} * x + { lineData1[CONCTANT]} и y = {lineData2[COEFFICIENT]} * x + {lineData2[CONCTANT]}");
    Console.WriteLine($"имеет координаты  ({coord[X_COORD]},{coord[Y_COORD]})");
}

Double Prompt(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите кооэфициент для {numberOfLine} прямой >");
    lineData[CONCTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONCTANT] - lineData2[CONCTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData1[CONCTANT] * coord[X_COORD] + lineData1[CONCTANT];
    return coord;
}

bool ValidataLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONCTANT] == lineData2[CONCTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("прямые паралельны");
            return false;
        }
    }
    return true;
}