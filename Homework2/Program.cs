using System;
using System.Security.Cryptography.X509Certificates;

namespace HoweWork2 {
    class Program
        {
    /// <summary>
    /// Структура для хранения статистики пользователя.
    /// Содержит PIN-код, фамилию, город проживания и возраст.
    /// </summary>
    struct UserStats {
        /// <summary>
        /// ПИН-код пользователя.
        /// </summary>
        public int UserPIN;
        
        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string UserSName;
        
        /// <summary>
        /// Город, в котором проживает пользователь.
        /// </summary>
        public string UserCity;
        
        /// <summary>
        /// Возраст пользователя.
        /// </summary>
        public int UserAge;
    }

    /// <summary>
    /// Структура для хранения информации о студенте.
    /// Содержит имя, фамилию, ID студента, дату рождения, категорию алкоголя, тип и объем алкоголя.
    /// </summary>
    struct Student {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string Name;
        
        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string Surname;
        
        /// <summary>
        /// Идентификатор студента.
        /// </summary>
        public int StudentID;
        
        /// <summary>
        /// Дата рождения студента.
        /// </summary>
        public string DateOfBirth;
        
        /// <summary>
        /// Категория алкоголизма (в виде символа).
        /// </summary>
        public char AlcoholCategory;
        
        /// <summary>
        /// Объем выпитого алкоголя.
        /// </summary>
        public int AlcoVolume;
        
        /// <summary>
        /// Тип предпочитаемого алкоголя (например, пиво, водка).
        /// </summary>
        public string AlcoType;
    }

    /// <summary>
    /// Структура для хранения информации о типе алкоголя.
    /// Включает название алкоголя и процентное содержание алкоголя.
    /// </summary>
    struct AlcoholType {
        /// <summary>Название алкоголя.</summary>
        public string NameOfAlco;
        
        /// <summary>Процентное содержание алкоголя.</summary>
        public int AlcoPercentage;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("\nУпражнение 1.\n");
            Console.WriteLine("Выведите на экран информацию о каждом типе данных в виде: Тип данных – максимальное значение – минимальное значение");

            Console.WriteLine("Тип данных C#\tМаксимальное значение\t\t\tМинимальное значение");

            Console.WriteLine($"sbyte\t\t{SByte.MaxValue}\t\t\t\t{SByte.MinValue}");
            Console.WriteLine($"byte\t\t{Byte.MaxValue}\t\t\t\t{Byte.MinValue}");
            Console.WriteLine($"short\t\t{Int16.MaxValue}\t\t\t\t{Int16.MinValue}");
            Console.WriteLine($"ushort\t\t{UInt16.MaxValue}\t\t\t\t{UInt16.MinValue}");
            Console.WriteLine($"int\t\t{Int32.MaxValue}\t\t\t{Int32.MinValue}");
            Console.WriteLine($"uint\t\t{UInt32.MaxValue}\t\t\t{UInt32.MinValue}");
            Console.WriteLine($"long\t\t{Int64.MaxValue}\t\t{Int64.MinValue}");
            Console.WriteLine($"ulong\t\t{UInt64.MaxValue}\t\t{UInt64.MinValue}");
            Console.WriteLine($"float\t\t{Single.MaxValue}\t\t\t{Single.MinValue}");
            Console.WriteLine($"double\t\t{Double.MaxValue}\t\t{Double.MinValue}");
            Console.WriteLine($"decimal\t\t{Decimal.MaxValue}\t{Decimal.MinValue}");

            Console.WriteLine("\nУпражнение 2.\n");
            Console.WriteLine("Напишите программу, в которой принимаются данные пользователя в виде имени, города, возраста и PIN-кода. Далее сохраните все значение в соответствующей переменной, а затем распечатайте всю информацию в правильном формате.");

            Console.WriteLine("Впишите данные пользователя для справик.");
            
            UserStats MyStats = new UserStats();
            Console.WriteLine("Впишите Пин-код аккаунта пользователя, используйте только цифры:");
            try {
                MyStats.UserPIN = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) {
                Console.WriteLine("Ошибка формата. Нам не удастся вывести все данные.");
            }

            Console.WriteLine("Впишите имя пользователя:");
            MyStats.UserSName = Console.ReadLine();

            Console.WriteLine("Впишите возраст пользователя. Используйте только цифры.");
            try {
                MyStats.UserAge = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) {
                Console.WriteLine("Ошибка формата. Нам не удастся вывести все данные.");}

            Console.WriteLine("Впишите город пользователя:");
            MyStats.UserCity = Console.ReadLine();
            Console.WriteLine($"Город пользователя: {MyStats.UserCity} \nВозраст пользователя: {MyStats.UserAge} \nPIN пользователя: {MyStats.UserPIN} \nИмя пользователя: {MyStats.UserSName}");
            
            Console.WriteLine("\nУпражнение 3.\n");
            Console.WriteLine("Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные.");

            Console.WriteLine("Введите строчку, буквы которой будут преобразованы(заглавные в строчные, строчные в заглавные)");

            string StrInput = Console.ReadLine();

            char[] result = new char[StrInput.Length];
            for (int i = 0; i < StrInput.Length; i++) {
                char c = StrInput[i];
                if (char.IsUpper(c)) {
                    result[i] = char.ToLower(c);
                } else if (char.IsLower(c)) {
                    result[i] = char.ToUpper(c);
                } else {
                    result[i] = c;
                }
            }

            string swappedCaseString = new string(result);
            Console.WriteLine("Строка с измененным регистром: " + swappedCaseString);

            Console.WriteLine("\nУпражнение 4.\n");
            Console.WriteLine("Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.");

            Console.WriteLine("Введите строку на первой строчке, на второй - подстроку:");
            string StringMain = Console.ReadLine();
            string StringOptional = Console.ReadLine();

            int StrCount = StringMain.Split(StringOptional).Length - 1;

            Console.WriteLine($"Строка '{StringOptional}' вошла в строку '{StringMain}' {StrCount} раз");

            Console.WriteLine("\nУпражнение 5.\n");
            Console.WriteLine("Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск.");
            Console.WriteLine("Введите стоимость отпуска");
            double holidayPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стандартную цену бутылки виски");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скидку Duty Free");
            double salePrice = Convert.ToDouble(Console.ReadLine());
            if (salePrice > 100 || salePrice < 0) {
                Console.WriteLine("Ошибка. Скидка находится диапазоне [0,100]"); }
            else {
                double DutyFreeDiscount = (double)(normPrice * salePrice * 0.01);
                int PriceForHoliday = (int)(Math.Floor(holidayPrice/DutyFreeDiscount));
                Console.WriteLine($"Чтобы покрыть расходы на отпуск, необходимо купить {PriceForHoliday} бутылок");
            }
            
            Console.WriteLine("\nУпражнение 6.\n");
            Console.WriteLine("Посчитать общий объем выпитого, общий объем алкоголя (процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества выпил.");

            AlcoholType beer = new AlcoholType();
            beer.AlcoPercentage = 5;
            beer.NameOfAlco = "Пиво";
            AlcoholType vodka = new AlcoholType();
            vodka.AlcoPercentage = 40;
            vodka.NameOfAlco = "Водка";
            AlcoholType wine = new AlcoholType();
            wine.AlcoPercentage = 11;
            wine.NameOfAlco = "Вино";

            Student[] students = new Student[] {
            new Student { AlcoholCategory = 'a', DateOfBirth = "31.10.2003", Name = "Ваня", StudentID = 1556, Surname = "Мастурбеков", AlcoType = "Пиво", AlcoVolume= 8245 },
            new Student { AlcoholCategory = 'b', DateOfBirth = "15.12.2001", Name = "Андрей", StudentID = 355, Surname = "Андреев", AlcoType = "Водка", AlcoVolume = 3555 },
            new Student { AlcoholCategory = 'c', DateOfBirth = "06.8.2000", Name = "Александр", StudentID = 663, Surname = "Александров", AlcoType = "Вино", AlcoVolume = 3733 },
            new Student { AlcoholCategory = 'd', DateOfBirth = "12.4.2005", Name = "Василий", StudentID = 236, Surname = "Васильев", AlcoType = "Пиво", AlcoVolume = 5255 },
            new Student { AlcoholCategory = 'a', DateOfBirth = "25.11.2004", Name = "Антон", StudentID = 7743, Surname = "Антонов", AlcoType = "Водка", AlcoVolume = 5569 }
            };
            double AlcoSum = 0;
            double AlcoSumPercentage = 0;

            foreach (Student student in students) {
                int Percentage = 0;
                if (student.AlcoType == beer.NameOfAlco) {
                    Percentage = beer.AlcoPercentage;}
                else if (student.AlcoType == wine.NameOfAlco) {
                    Percentage = wine.AlcoPercentage;}
                else if (student.AlcoType == vodka.NameOfAlco) {
                    Percentage = vodka.AlcoPercentage;}

                AlcoSum += student.AlcoVolume;
                AlcoSumPercentage += student.AlcoVolume * (Percentage * 0.01);}
            Console.WriteLine($"Выпито жидкости: {AlcoSum}\nВыпито спирта: {AlcoSumPercentage}");
            foreach (Student student in students) {
                int AlcoPercentage = 0;
                if (student.AlcoType == beer.NameOfAlco) {
                    AlcoPercentage = beer.AlcoPercentage;}
                else if (student.AlcoType == wine.NameOfAlco) {
                    AlcoPercentage = wine.AlcoPercentage;}
                else if (student.AlcoType == vodka.NameOfAlco) {
                    AlcoPercentage = vodka.AlcoPercentage;}
                Console.WriteLine($"Студент {student.Name} {student.Surname} Выпил {student.AlcoVolume / AlcoSum * 100}% жидкости");
                Console.WriteLine($"Студент {student.Name} {student.Surname} Выпил {student.AlcoVolume * AlcoPercentage / AlcoSumPercentage }% алкоголя");


                
            }

        }
    
    }
}
