/* Домашна работа на Андрей Марков №4 от 10В клас
Задача: Да се определят височините на триъгълник по зададени страни a, b и c.
От сайта: https://iliyankovachev.wordpress.com/етапи-при-решаване-на-задачи-с-компютъ/
*/

using System.Text;

class Triangle
{
    public double a, b, c, s, ha, hb, hc, S;

    static void Main(string[] args)
    {
        // Иначе излизат ????? вместо български букви
        Console.OutputEncoding = Encoding.UTF8;
        
        Triangle triangle = new Triangle();

        Console.Write("Страната a е равна на: ");
        triangle.a = double.Parse(Console.ReadLine());
        Console.Write("Страната b е равна на: ");
        triangle.b = double.Parse(Console.ReadLine());
        Console.Write("Страната c е равна на: ");
        triangle.c = double.Parse(Console.ReadLine());
        
        // Използваме формулата на Херон и намираме полупериметъра на триъгълника
        triangle.s = (triangle.a + triangle.b + triangle.c) / 2;

        // Намираме лицето на триъгълника по формулата на Херон, защото имаме дадени само страните a, b и c
        triangle.S = Math.Sqrt(triangle.s * (triangle.s - triangle.a) * (triangle.s - triangle.b) * (triangle.s - triangle.c));

        triangle.ha = (2 * triangle.S) / triangle.a;
        triangle.hb = (2 * triangle.S) / triangle.b;
        triangle.hc = (2 * triangle.S) / triangle.c;

        Console.WriteLine($"\nЛицето S на триъгълника е равно на: {Math.Round(triangle.S,2)}");
        Console.WriteLine($"Полупериметъра на триъгълника е равен на: {triangle.s}");
        Console.WriteLine($"Височината ha е равна на: {Math.Round(triangle.ha,2)}");
        Console.WriteLine($"Височината hb е равна на: {Math.Round(triangle.hb,2)}");
        Console.WriteLine($"Височината hc е равна на: {Math.Round(triangle.hc,2)}");
        
        Console.ReadKey();
    }
}