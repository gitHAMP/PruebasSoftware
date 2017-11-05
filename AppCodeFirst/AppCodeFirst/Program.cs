using AppCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AppCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new EFContext())
                {
                    // Create demo: Create a User instance and save it to the database
                    User newUser = new User { FirstName = "Anna", LastName = "Shrestinian" };
                    context.User.Add(newUser);
                    context.SaveChanges();
                    Console.WriteLine($"\nCreated User:{newUser.ToString()}");

                    // Create demo: Create a Task instance and save it to the database
                    Task newTask = new Task() { Title = "Ship Helsinki", IsComplete = false, DueDate = DateTime.Parse("04-01-2017") };
                    context.Task.Add(newTask);
                    context.SaveChanges();
                    Console.WriteLine($"\nCreated Task:{newTask.ToString()}");


                    // Association demo: Assign task to user
                    newTask.AssignedTo = newUser;
                    context.SaveChanges();
                    Console.WriteLine($"\nAssigned Task:{newTask.Title} to user: {newUser.GetFullName()}");

                    // Read demo: find incomplete tasks assigned to user 'Anna'
                    Console.WriteLine("\nIncomplete tasks assigned to 'Anna':");
                    var query = from t in context.Task
                                where t.IsComplete == false &&
                                t.AssignedTo.FirstName.Equals("Anna")
                                select t;
                    foreach (var t in query)
                    {
                        Console.WriteLine(t.ToString());
                    }

                    // Update demo: change the 'dueDate' of a task
                    Task taskToUpdate = context.Task.First(); // get the first task
                    Console.WriteLine($"\nUpdating task:{taskToUpdate.ToString()}");                    
                    taskToUpdate.DueDate = DateTime.Parse("11-03-2017");
                    context.SaveChanges();
                    Console.WriteLine($"\ndueDate changed:{taskToUpdate.ToString()}");


                    // Delete demo: delete all tasks with a dueDate in 2017
                    Console.WriteLine($"\nDeleting all tasks with a dueDate in 2017");
                    
                    DateTime dueDate2017 = DateTime.Parse("03-11-2017");
                    query = from t in context.Task
                            where t.DueDate < dueDate2017
                            select t;
                    foreach (Task t in query)
                    {
                        Console.WriteLine($"\nDeleting task:{t.ToString()}");
                        
                        context.Task.Remove(t);
                    }
                    context.SaveChanges();


                    // Show tasks after the 'Delete' operation - there should be 0 tasks
                    Console.WriteLine("\nTasks after delete:");
                    List<Task> tasksAfterDelete = (from t in context.Task select t).ToList<Task>();
                    if (tasksAfterDelete.Count == 0)
                    {
                        Console.WriteLine("[None]");
                    }
                    else
                    {
                        foreach (Task t in query)
                        {
                            Console.WriteLine(t.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}
