using System.Linq; // возьмём дополнительный модуль

string text = "(1,2) (2,3) (4,5) (6,7)" // набор  данных в виде координат точек
                .Replace("(", "") // замена ( на пустой символ
                .Replace(")", "")
                ;
Console.WriteLine(text);

var data = text.Split(" ") // метод Split позволяет сделать разбивку с учётом символа разделителя (здесь - пробел)
                .Select(item => item.Split(',')) // получение подмассива координат
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // получаем массив кортеджей
                .Where(e => e.x % 2 == 0) // получим точки у которых х координата буде чётной
                .Select(point => (point.x * 10, point.y)) // увеличени х в 10 рах в каждой координате
                .ToArray(); // полученный набор данных превращаем в массив

for(int i = 0; i < data.Length; i++) 
{
    Console.WriteLine(data[i]);
}
