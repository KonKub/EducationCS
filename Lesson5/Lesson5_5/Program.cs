using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_5
{
    public class ToDo
    {
        public string Title { set; get; }
        public bool IsDone { set; get; }

        public ToDo() { }
        public ToDo(string T, bool D) 
        {
            Title = T;
            IsDone = D;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "tasks.xml";
            List<ToDo> ToDoList = new List<ToDo>();
            XmlSerializer xml = new XmlSerializer(typeof(List<ToDo>));
            string S;
            int N;

            //Запись списка в файл
            void SaveTaskList()
            {
                using (Stream fStream = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    xml.Serialize(fStream, ToDoList);
                }
                
                Console.WriteLine("Tasks saved!");
            }

            void ReadTaskList()
            {
                try
                {
                    using (Stream fStream = File.Open(FileName, FileMode.Open))
                    {
                        foreach (ToDo Task in (List<ToDo>)xml.Deserialize(fStream))
                            ToDoList.Add(Task);
                    }
                }
                catch
                {
                }
            }

            void ShowTaskList()
            {
                if (ToDoList.Count > 0)
                {
                    Console.WriteLine("Список задач:");
                    for (int i = 0; i < ToDoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}  [{(ToDoList[i].IsDone ? 'x' : ' ')}]  {ToDoList[i].Title}");
                    }
                }
                else 
                {
                    Console.WriteLine("Нет задач для выполнения.");
                }
            }

            ReadTaskList();

            while(true)
            {

                ShowTaskList();

                Console.WriteLine("Ведите номер задачи для отметки о выполнении или ");
                Console.WriteLine("название новой задачи для добавления в список (должна иметь хотябы один символ в ).");
                Console.WriteLine("Для выхода введите {0}.","e");
                Console.Write(">");
                S =Console.ReadLine();

                try 
                {
                    N= Int32.Parse(S);
                    if (N > 0 && N <= ToDoList.Count)
                    {
                        ToDoList[N-1].IsDone = true;
                    }
                }
                catch
                {
                    if (S == "e" || S == "E") break;
                    ToDoList.Add(new ToDo(S, false));
                }
            }

            SaveTaskList();
        }
    }
}
