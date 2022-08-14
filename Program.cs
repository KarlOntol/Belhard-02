using System;

namespace Belhard_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Check();
        }

        private static void Check()
        {
            /*Программа принимает на вход число и пытается преобразовать его в тип long,
            если срабатывает исключение переполнения, то пытается преобразовать в тип ulong,
            если это удается, программа завершается (потому что это будет означать, что число 
            больше long и меньше ulong, следовательно может принадлежать только к типу ulong),
            если не получается и это, то срабатывает исключение недопустимого диапазона значений.
            Далее программа пытается преобразовать число к каждому типу значений кроме long, так как
            по умолчанию уже является им. Следует обратить внимание, что при преобразовании к типу ulong 
            выполняется всего одна проверка: больше нуля, так как слишком большое число заранее не допускается
            к дальнейшему выполнению программы. И если проверять по Uint64.MaxValue и Uint64.MinValue,
            срабатывает исключение: Operator '<=' cannot be applied to operands of type 'long' and 'ulong'.
            */

            System.Console.WriteLine("Введите целое число: ");
            string? myNumber = Console.ReadLine();
            dynamic number;
            try
            {
                number = Convert.ToInt64(myNumber);
                System.Console.WriteLine("Число входит в допустимый числовой диапазон и может быть преобразовано в другие типы");
            }
            catch (System.OverflowException)
            {
                try
                {
                    number = Convert.ToUInt64(myNumber);
                    System.Console.WriteLine("Это число типа ulong слишком большое, чтобы преобразовать его в другие типы данных");
                    return;
                }
                catch (System.OverflowException)
                {                    
                    // throw new Exception("Число не входит в диапазон допустимых значений");
                    Console.WriteLine("Число не входит в диапазон допустимых значений");
                    return;
                }
            }

            // Проверка на byte
            if (number >= byte.MinValue && number <= byte.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в byte: {Convert.ToByte(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип byte, оно должно быть меньше или равно {byte.MaxValue} и больше или равно {byte.MinValue}");
            }

            // Проверка на sbyte
            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в sbyte: {Convert.ToSByte(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип sbyte, оно должно быть меньше или равно {sbyte.MaxValue} и больше или равно {sbyte.MinValue}");
            }

            // Проверка на short
            if (number >= Int16.MinValue && number <= Int16.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в short: {Convert.ToInt16(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип short, оно должно быть меньше или равно {Int16.MaxValue} и больше или равно {Int16.MinValue}");
            }

            // Проверка на ushort
            if (number >= UInt16.MinValue && number <= UInt16.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в ushort: {Convert.ToUInt16(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип ushort, оно должно быть меньше или равно {UInt16.MaxValue} и больше или равно {UInt16.MinValue}");
            }

            // Проверка на int
            if (number >= Int32.MinValue && number <= Int32.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в int: {Convert.ToInt32(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип int, оно должно быть меньше или равно {Int32.MaxValue} и больше или равно {Int32.MinValue}");
            }

            // Проверка на uint
            if (number >= UInt32.MinValue && number <= UInt32.MaxValue)
            {
                System.Console.WriteLine($"Преобразование в uint: {Convert.ToUInt32(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип uint, оно должно быть меньше или равно {UInt32.MaxValue} и больше или равно {UInt32.MinValue}");
            }

            // Проверка на ulong
            if (number >= 0)
            {
                System.Console.WriteLine($"Преобразование в ulong: {Convert.ToUInt64(number)}");
            }
            else
            {
                System.Console.WriteLine($"Чтобы преобразовать число {number} в тип ulong, оно должно быть меньше или равно {UInt64.MaxValue} и больше или равно {UInt64.MinValue}");
            }
        }
    }
}
