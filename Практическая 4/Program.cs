using System;

public class DivisionProgram
{
    public static double GetNumberFromUser(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                return number;
            }
            Console.WriteLine("Неверный формат числа. Повторите ввод.");
        }
    }


    public static void Main(string[] args)
    {
        try
        {
            double num1 = GetNumberFromUser("Введите первое число которрое вам нравится: ");
            double num2 = GetNumberFromUser("Введите второе число которое вам не нравится: ");
            double result = num1 * num2;
            Console.WriteLine($"Результат который вам может понравится или нет: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Программа завершена. Спасибо за работу!");
        }
    }
}


