using System;

namespace Lab_W_2{
    class Program {
        enum TypeOfBankAccount {
            /* Создаю перечислимый тип данных отображающий виды банковского
            счета (текущий и сберегательный). */
            Текущий,
            Сберегательный
        }
        struct UserBankAccInfo {
            /*Создать структуру данных, которая хранит информацию о банковском
            счете – его номер, тип и баланс.*/
            public int AccNumber;
            public TypeOfBankAccount BankType;
            public int AccBalance;
        }
        enum UniversityName {
            /*Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. */
            КГУ,
            КАИ,
            КХТИ
        }
        struct UnviersityWorker {
            /* Создать структуру работник с двумя полями: имя, ВУЗ. */
            public string name;
            public UniversityName university;
        }
        static void Main (string[] args) {

            Console.WriteLine("\nУпражнение №3.1\n");

            TypeOfBankAccount UserAcc = TypeOfBankAccount.Сберегательный;
            Console.WriteLine($"Тип счета в банке у какого-то пользователя - {UserAcc}");

            Console.WriteLine("\nУпражнение №3.2\n");

            UserBankAccInfo RandUserInfo = new UserBankAccInfo();
            RandUserInfo.AccBalance = 228228228;
            RandUserInfo.AccNumber = 666666;
            RandUserInfo.BankType = TypeOfBankAccount.Сберегательный;
            Console.WriteLine("Счет пользователя в банке равен: {0}\nНомер аккаунта пользователя в системе банка: {1}\nТип аккаунта в банке: {2}", RandUserInfo.AccBalance, RandUserInfo.AccNumber, RandUserInfo.BankType);

            Console.WriteLine("\nУпражнение №3.3\n");

            UnviersityWorker Tutor = new UnviersityWorker();
            Tutor.name = "Иван Золо";
            Tutor.university = UniversityName.КГУ;
            Console.WriteLine("Работника зовут: {0}\nРаботник прикреплен к ВУЗу:{1}", Tutor.name,Tutor.university);
        }
    }
}