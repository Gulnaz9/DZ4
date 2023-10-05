using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Usersss
{
    internal class Program
    {
        enum Grouchiness
        {
            Ворчун_бабай,
            Осуждающий,
            Матур_бабай,
            Мозай_бабай
        }
        struct Дед

        {
            public string name;
            public Grouchiness level;
            public string[] Phrases;
            public int bruises;
            public void GrandmaHits(params string[] SwearWords)
            { 
               foreach (string word in Phrases)
                {
                    if (Array.IndexOf(SwearWords, word.ToLower()) != -1)
                    {
                        bruises++;
                    }
                }
            }
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 3\nПользователь вводит числа, в зависимости от значения которых что-нибудь происходит");
            Console.WriteLine("Введите число или закройте программу");
            try
            {
                string func1 = Console.ReadLine();
                if (func1.ToLower() == "exit" || func1.ToLower() == "закрыть") { }
                else
                {
                    int func = Convert.ToInt32(func1);
                    if (func >= 0 && func <= 9)
                    {
                        switch (func)
                        {
                            case 0: Console.WriteLine("###\n# #\n# #\n# #\n###"); break;
                            case 1: Console.WriteLine(" #\n## \n #\n #\n###"); break;
                            case 2: Console.WriteLine(" #\n# #\n  #\n #\n###"); break;
                            case 3: Console.WriteLine("###\n  #\n #\n  #\n###"); break;
                            case 4: Console.WriteLine("# #\n# #\n###\n  #\n  #"); break;
                            case 5: Console.WriteLine("###\n#\n###\n  #\n###"); break;
                            case 6: Console.WriteLine("###\n#\n###\n# #\n###"); break;
                            case 7: Console.WriteLine("###\n  #\n ##\n  #\n  #"); break;
                            case 8: Console.WriteLine("###\n# #\n###\n# #\n###"); break;
                            case 9: Console.WriteLine("###\n# #\n###\n  #\n###"); break;
                            default:
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ошибка");
                                Thread.Sleep(3000);
                                Console.BackgroundColor = ConsoleColor.Black; break;
                        }
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы совершили не предусмотренное действие");
            }

            Console.WriteLine("Упр 4\nНаписать метод, который на вход принимает деда. Вернуть количество фингалов.");
            string[] SwearWords = { "мат1", "мат2", "мат3", "мат4", "мат5", "мат6" };


            Дед Макар = new Дед();
            Макар.name = "Макар";
            Grouchiness Mgrouchinesslvl = Grouchiness.Ворчун_бабай;
            Макар.level = Mgrouchinesslvl;
            string[] MakarPhrases = { "мат1", "мат2", "мат3", "мат4", "мат5", "Хулиганы", "Фашисты", "Дэбилы" };
            Макар.Phrases = MakarPhrases;
            Макар.bruises = 0;
            Макар.GrandmaHits(SwearWords);


            Дед Илья = new Дед();
            Илья.name = "Илья";
            Grouchiness Igrouchinesslvl = Grouchiness.Матур_бабай;
            Илья.level = Igrouchinesslvl;
            string[] IlyaPhrases = { "мат1","Хулиганы","Потерянное поколение","Неучи"};
            Илья.Phrases = IlyaPhrases;
            Илья.bruises = 0;
            Илья.GrandmaHits(SwearWords);


            Дед Василий = new Дед();
            Василий.name = "Василий";
            Grouchiness Vgrouchinesslvl = Grouchiness.Ворчун_бабай;
            Василий.level = Vgrouchinesslvl;
            string[] VasilyPhrases = { "мат1","мат2","мат3","Дэбилы", "Неучи", "Гады" };
            Василий.Phrases = VasilyPhrases;
            Василий.bruises = 0;
            Василий.GrandmaHits(SwearWords);


            Дед Данил = new Дед();
            Данил.name = "Данил";
            Grouchiness Dgrouchinesslvl = Grouchiness.Осуждающий;
            Данил.level = Dgrouchinesslvl;
            string[] DanilPhrases = { "мат1", "мат2", "Неучи", "Гады", "Фашисты" };
            Данил.Phrases = DanilPhrases;
            Данил.bruises = 0;
            Данил.GrandmaHits(SwearWords);


            Дед Пётр = new Дед();
            Пётр.name = "Пётр";
            Grouchiness Pgrouchinesslvl = Grouchiness.Мозай_бабай;
            Пётр.level = Pgrouchinesslvl;
            string[] PetrPhrases = { "Мат1", "Потерянное поколение" };
            Пётр.Phrases = PetrPhrases;
            Пётр.bruises = 0;
            Пётр.GrandmaHits(SwearWords);

            Console.WriteLine($"Дед {Макар.name} получил {Макар.bruises} фингалов\nДед {Илья.name} - {Илья.bruises}\nДед {Василий.name} - {Василий.bruises}\nДед {Данил.name} - {Данил.bruises}\nДед {Пётр.name} - {Пётр.bruises}");
        }
    }
}
