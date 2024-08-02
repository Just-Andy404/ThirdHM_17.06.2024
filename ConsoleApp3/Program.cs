/*
 Создайте приложение-эмуляцию очереди в поликлинику. Пациенты 
приходят к врачу, но попадают в очередь. Если в очереди три пациента 
пациента и приходит четвертый, он попадает в конец очереди. 
Врач принимает по одному пациенту за определенный интервал времени.
При разработке приложения используйте класс PriorityQueue.
 */

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new PriorityQueue<string, int>();
            queue.Enqueue("Robert", 2);
            queue.Enqueue("Andrii", 1);
            queue.Enqueue("Stive", 4);
            queue.Enqueue("Max", 3);

            Console.WriteLine("Прием пациентов");
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                Console.WriteLine($"Врач принимает: {item}");
            }
        }
    }
}
