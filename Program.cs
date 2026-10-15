// using System.Text;
// int number = 305419896;
// System.Console.WriteLine($"Число: {number}");
// System.Console.WriteLine($"В hex: 0x{number:X8}");
// System.Console.WriteLine($"Little-endian: {BitConverter.IsLittleEndian}");
// byte[] numberbytes = BitConverter.GetBytes(number);
// System.Console.WriteLine("Байты числа:");
// System.Console.WriteLine(BitConverter.ToString(numberbytes));
// string text = "Hello";
// System.Console.WriteLine();
// System.Console.WriteLine($"ТЕкст: {text}");
// byte[] textbytes = Encoding.UTF8.GetBytes(text);
// System.Console.WriteLine("Байты текста UTF-8:");
// System.Console.WriteLine(BitConverter.ToString(textbytes));

// using System.Text;

// string text2 = "Privet";
// byte[] textBytes2 = Encoding.UTF8.GetBytes(text2);
// System.Console.WriteLine();
// System.Console.WriteLine($"Текст:{text2}");
// System.Console.WriteLine($"Количество символов:{text2.Length}");
// System.Console.WriteLine($"Количество байтов UTF-8:{textBytes2.Length}");
// System.Console.WriteLine($"Байты:{BitConverter.ToString(textBytes2)}");

// using System.Text;

// string english = "A";
// string russian = "А";
// byte[] englishBytes = Encoding.UTF8.GetBytes(english);
// byte[] russianBytes = Encoding.UTF8.GetBytes(russian);
// System.Console.WriteLine($"А: {BitConverter.ToString(englishBytes)}");
// System.Console.WriteLine($"А: {BitConverter.ToString(russianBytes)}");

// using System.Text;

// string text3 = "Привет";
// byte[] bytes = Encoding.UTF8.GetBytes(text3);
// string restored = Encoding.UTF8.GetString(bytes);
// System.Console.WriteLine($"Исходная строка: {text3}");
// System.Console.WriteLine($"Восстановленная: {restored}");

int number2 = 123456789;
byte[] bytes2 = BitConverter.GetBytes(number2);
int restored2 = BitConverter.ToInt32(bytes2, 0);
System.Console.WriteLine($"Исходное число: {number2}");
System.Console.WriteLine($"Восстановленное: {restored2}");
System.Console.WriteLine($"Байты: {BitConverter.ToString(bytes2)}");