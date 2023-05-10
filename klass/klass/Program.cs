public class Proverca
{
    public double prov()
    {
        double a;
        do
        {
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");
                return a;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода");
            }
        } while (true);
    }
};

public class Kalk
{
    public double add(double a, double b)
    {
        return a + b;
    }

    public double sub(double a, double b)
    {
        return a - b;
    }

    public double mul(double a, double b)
    {
        return a * b;
    }

    public double div(double a, double b)
    {
        return a / b;
    }

};
class prodram
{
    static void Main(string[] args)
    {
        Kalk k = new Kalk();
        Proverca p = new Proverca();
        int n = 0;
        double a = 0, b = 0, res = 0;
        //вводд чисел
        Console.WriteLine("введите число a=");
        a = p.prov();
        Console.WriteLine("введите число b=");
        b = p.prov();
        //цикл
        do
        {
            //выбор действий
            Console.WriteLine("выберите операцию\n 1-сложение\n 2-вычитание\n 3-умножение\n 4-деление\n 9-выход");
            n = Convert.ToInt32(p.prov());
            switch (n)
            {
                //сложение
                case 1:
                    res = k.add(a, b);
                    Console.WriteLine("{0}+{1}={2}", a, b, res);
                    break;
                //вычитание
                case 2:
                    res = k.sub(a, b);
                    Console.WriteLine("{0}-{1}={2}", a, b, res);
                    break;
                //умножение
                case 3:
                    res = k.mul(a, b);
                    Console.WriteLine("{0}*{1}={2}", a, b, res);
                    break;
                //деление
                case 4:
                    //проверка деления на 0
                    if (b != 0)
                    {
                        res = k.div(a, b);
                        Console.WriteLine("{0}/{1}={2}", a, b, res);

                    }
                    else
                    {
                        Console.WriteLine("деление на 0 невозможно\nвведите новое значение b");
                        while (b == 0)
                        {
                            b = p.prov();
                            if (b == 0)
                            {
                                Console.WriteLine("деление на 0 невозможно\nвведите новое значение b");
                            }
                        }
                        res = k.div(a, b);
                        Console.WriteLine("{0}/{1}={2}", a, b, res);

                    }
                    break;
                case 9:
                    Console.WriteLine("выход");
                    break;
                default:
                    Console.WriteLine("некоректный выбор операции");
                    break;
            }
        } while (n != 9);

    }
}
