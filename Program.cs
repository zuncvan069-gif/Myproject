using System;
public class Лампа
{
    public void Включить()
    {
        Console.WriteLine(" Лампа включена");
    }
}
public class Кондиционер
{
    public void ЗапуститьОхлаждение()
    {
        Console.WriteLine(" Кондиционер запущен");
    }
}
public class Телевизор
{
    public void ВключитьТВ()
    {
        Console.WriteLine(" Телевизор включен");
    }
}
public class УмныйДомФасад
{
    private Лампа лампа;
    private Кондиционер кондиционер;
    private Телевизор телевизор;

    public УмныйДомФасад()
    {
        лампа = new Лампа();
        кондиционер = new Кондиционер();
        телевизор = new Телевизор();
    }
    public void ВключитьВсеУстройства()
    {
        лампа.Включить();
        кондиционер.ЗапуститьОхлаждение();
        телевизор.ВключитьТВ();
    }
}
class Program
{
    static void Main(string[] args)
    {
        var умныйДом = new УмныйДомФасад();
        умныйДом.ВключитьВсеУстройства();
    }
}
