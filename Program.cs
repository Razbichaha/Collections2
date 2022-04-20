using System;
using System.Collections.Generic;


namespace Collections2
{

//    У вас есть множество целых чисел.Каждое целое число - это сумма покупки.
//Вам нужно обслуживать клиентов до тех пор, пока очередь не станет пуста.
//После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
//После обслуживания каждого клиента программа ожидает нажатия любой клавиши,
//после чего затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом


    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> money = new Queue<int>();

            QueueGenerator(money);
            BoxOffice(money);

        }

        static void BoxOffice(Queue <int> queue)
        {
            int moneyInCashRegister = 0;

            foreach(int money in queue)
            {
                Console.Clear();

                Console.WriteLine("Для проведения операции нажмите enter");
                Console.WriteLine("В кассу внесено - " + money + " денег");

                moneyInCashRegister += money;

                Console.WriteLine("Денег на вашем счету после проведения операции - " + moneyInCashRegister);
                Console.ReadLine();
            }

            Console.WriteLine("Очередь обслужена, ваш доход - " + moneyInCashRegister);
            Console.ReadLine();
        }

        static void QueueGenerator(Queue <int> queue)
        {
            int queueLength = 10;
            int startRandom = 10;
            int stopRandom = 100;

            Random random = new Random();

            for(int i=0;i<queueLength;i++)
            {
                queue.Enqueue(random.Next(startRandom, stopRandom));
            }
        }
    }
}
