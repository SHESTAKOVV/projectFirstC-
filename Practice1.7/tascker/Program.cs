using Newtonsoft.Json;

namespace tascker;

public class Program
{
        static List<Task>? _list = new List<Task>();
        static string _pathFile = "tasks.json";

        static void Main()
        {
            LoadTasks();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1 - Добавить задачу");
                Console.WriteLine("2 - Удалить задачу");
                Console.WriteLine("3 - Редактировать задачу");
                Console.WriteLine("4 - Просмотреть задачи на сегодня");
                Console.WriteLine("5 - Просмотреть задачи на завтра");
                Console.WriteLine("6 - Просмотреть задачи на неделю");
                Console.WriteLine("7 - Просмотреть список всех задач");
                Console.WriteLine("8- Просмотреть список предстоящих задач");
                Console.WriteLine("9 - Просмотреть список выполненных задач");
                Console.WriteLine("0 - Выйти");

                Console.Write("Выберите действие: ");
                int chose = Convert.ToInt32(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        EditTask();
                        break;
                    case 4:
                        ShowTasksForToday();
                        break;
                    case 5:
                        ShowTasksForTomorrow();
                        break;
                    case 6:
                        ShowTasksForWeek();
                        break;
                    case 7:
                        ShowAllTasks();
                        break;
                    case 8:
                        ShowUpcomingTasks();
                        break;
                    case 9:
                        ShowCompletedTasks();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы пошли не по условию");
                        break;
                }
                SaveTasks();
            }
        }

        static void LoadTasks()
        {
            if (File.Exists(_pathFile))
            {
                string json = File.ReadAllText(_pathFile);
                _list = JsonConvert.DeserializeObject<List<Task>>(json);
            }
        }

        static void SaveTasks()
        {
            string json = JsonConvert.SerializeObject(_list);
            File.WriteAllText(_pathFile, json);
        }

        static void AddTask()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();

            Console.Write("Введите описание задачи: ");
            string description = Console.ReadLine();

            Console.Write("Введите дату выполнения задачи в формате ДД.ММ.ГГГГ: ");
            DateTime dueDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            if (title != null)
            {
                if (description != null)
                {
                    Task task = new Task(title, description, dueDate);
                    _list.Add(task);
                }
            }

            Console.WriteLine("Задача успешно добавлена!");
        }

        static void RemoveTask()
        {
            Console.Write("Введите номер задачи для удаления: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < _list.Count)
            {
                _list.RemoveAt(index);
                Console.WriteLine("Задача успешно удалена!");
            }
            else
            {
                Console.WriteLine("Неверный номер задачи!");
            }
        }

        static void EditTask()
        {
            Console.Write("Введите номер задачи для редактирования: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (_list != null && index >= 0 && index < _list.Count)
            {
                Task task = _list[index];

                Console.Write("Введите новое название задачи: ");
                string newTitle = Console.ReadLine();

                Console.Write("Введите новое описание задачи: ");
                string newDescription = Console.ReadLine();

                Console.Write("Введите новую дату выполнения задачи (в формате ДД.ММ.ГГГГ): ");
                DateTime newDueDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

                if (newTitle != null) task.Title = newTitle;
                if (newDescription != null) task.Description = newDescription;
                task.DueDate = newDueDate;

                Console.WriteLine("Задача успешно отредактирована!");
            }
            else
            {
                Console.WriteLine("Неверный номер задачи!");
            }
        }

        static void ShowTasksForToday()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Задачи на сегодня:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    if (task.DueDate.Date == today)
                    {
                        Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                    }
                }
        }

        static void ShowTasksForTomorrow()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine("Задачи на завтра:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    if (task.DueDate.Date == tomorrow)
                    {
                        Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                    }
                }
        }

        static void ShowTasksForWeek()
        {
            DateTime endOfWeek = DateTime.Today.AddDays(7);
            Console.WriteLine("Задачи на неделю:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    if (task.DueDate.Date <= endOfWeek)
                    {
                        Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                    }
                }
        }

        static void ShowAllTasks()
        {
            Console.WriteLine("Список всех задач:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                }
        }

        static void ShowUpcomingTasks()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Список предстоящих задач:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    if (task.DueDate.Date >= today)
                    {
                        Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                    }
                }
        }

        static void ShowCompletedTasks()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Список выполненных задач:");

                if (_list != null)
                foreach (Task task in _list)
                {
                    if (task.DueDate.Date < today)
                    {
                        Console.WriteLine($"{task.Title} {task.Description} {task.DueDate}");
                    }
                }
        }
    }

class Task 
{ 
    public string Title { get; set; } 
    public string Description { get; set; } 
    public DateTime DueDate { get; set; }
    public Task(string title, string description, DateTime dueDate) 
    { 
        Title = title; 
        Description = description; 
        DueDate = dueDate;
    }
}
