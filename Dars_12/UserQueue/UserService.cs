using System.Security.Cryptography.X509Certificates;

namespace Dars_12.UserQueue;

public class UserService
{
    public Queue<UserModel> UserQueues = new Queue<UserModel>();

    public Queue<UserModel> AddQueue()
    {
        UserQueues.Enqueue(new UserModel{FirstName = "John",MiddleName = "Darnell", LastName = "Doe"});
        UserQueues.Enqueue(new UserModel { FirstName = "Annabel", MiddleName = "Darnell", LastName = "Doe" });
        UserQueues.Enqueue(new UserModel { FirstName = "Philipp", MiddleName = "Darnell", LastName = "Doe" });
        UserQueues.Enqueue(new UserModel { FirstName = "Mike", MiddleName = "Darnell", LastName = "Doe" });
        UserQueues.Enqueue(new UserModel { FirstName = "Hamdam", MiddleName = "Don", LastName = "Eshmatov" });

        return UserQueues;
    }

    public void Display()
    {
        var queues = AddQueue();
        foreach (var queue in queues)
        {
            Console.WriteLine($"{queue.FirstName} {queue.MiddleName} {queue.LastName}");
        }
    }
    public void CheckQueueAddNew()
    {

        Console.Write($"Your first name: ");
        var firstName = Console.ReadLine();

        Console.Write($"Your Middle name: ");
        var middleName = Console.ReadLine();

        Console.Write($"Your Last name: ");
        var lastName = Console.ReadLine();

        var newQueue = new UserModel { FirstName = firstName, MiddleName = middleName, LastName = lastName };
        var queues = AddQueue();

        foreach (var queue in queues)
        {
            if (queue.GetHashCode().Equals(newQueue))
            {
                Console.Write("Bor siz!");
                break;
            }
            else
            {
                Console.Write("Qo'shilding ");
                break;
            }

        }
    }
}

