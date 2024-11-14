using System;

namespace Lab_W_2{
    class Program {
        /// <summary>
        /// Перечисление для представления типов банковского счета.
        /// Включает два типа: Текущий и Сберегательный.
        /// </summary>
        enum TypeOfBankAccount {
            Текущий,
            Сберегательный
        }

        /// <summary>
        /// Структура для хранения информации о банковском счете.
        /// Содержит номер счета, тип счета и текущий баланс.
        /// </summary>
        struct UserBankAccInfo {
            /// <summary>
            /// Номер банковского счета.
            /// </summary>
            public int AccNumber;

            /// <summary>
            /// Тип банковского счета (Текущий или Сберегательный).
            /// </summary>
            public TypeOfBankAccount BankType;

            /// <summary>
            /// Баланс на банковском счете.
            /// </summary>
            public int AccBalance;
        }

        /// <summary>
        /// Перечисление для представления названия университета.
        /// Включает ВУЗы: КГУ, КАИ, КХТИ.
        /// </summary>
        enum UniversityName {
            КГУ,
            КАИ,
            КХТИ
        }

        /// <summary>
        /// Структура для хранения информации о работнике университета.
        /// Содержит имя работника и название университета.
        /// </summary>
        struct UnviersityWorker {
            /// <summary>
            /// Имя работника университета.
            /// </summary>
            public string name;

            /// <summary>
            /// Университет, в котором работает сотрудник (КГУ, КАИ или КХТИ).
            /// </summary>
            public UniversityName university;
        }
        static void Main (string[] args) {

            Console.WriteLine("\nУпражнение №3.1\n");
        
            Console.WriteLine("Создаю перечислимый тип данных отображающий виды банковского счета (текущий и сберегательный).");
            TypeOfBankAccount UserAcc = TypeOfBankAccount.Сберегательный;
            Console.WriteLine($"Тип счета в банке у какого-то пользователя - {UserAcc}");

            Console.WriteLine("\nУпражнение №3.2\n");

            Console.WriteLine("Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.");
            UserBankAccInfo RandUserInfo = new UserBankAccInfo();
            RandUserInfo.AccBalance = 228228228;
            RandUserInfo.AccNumber = 666666;
            RandUserInfo.BankType = TypeOfBankAccount.Сберегательный;
            Console.WriteLine("Счет пользователя в банке равен: {0}\nНомер аккаунта пользователя в системе банка: {1}\nТип аккаунта в банке: {2}", RandUserInfo.AccBalance, RandUserInfo.AccNumber, RandUserInfo.BankType);

            Console.WriteLine("\nУпражнение №3.3\n");

            Console.WriteLine("Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}.Создать структуру работник с двумя полями: имя, ВУЗ.");
            UnviersityWorker Tutor = new UnviersityWorker();
            Tutor.name = "Иван Золо";
            Tutor.university = UniversityName.КГУ;
            Console.WriteLine("Работника зовут: {0}\nРаботник прикреплен к ВУЗу:{1}", Tutor.name,Tutor.university);
        }
    }
}