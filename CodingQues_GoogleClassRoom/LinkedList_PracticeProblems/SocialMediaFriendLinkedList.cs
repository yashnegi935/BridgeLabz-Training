namespace CalculatorProblems;

public class UserNode
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIds { get; set; }
    public UserNode? Next { get; set; }

    public UserNode(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        FriendIds = new List<int>();
        Next = null;
    }
}

public class SocialMediaGraphLinkedList
{
    private UserNode? head;

    public void AddUser(int userId, string name, int age)
    {
        UserNode newUser = new UserNode(userId, name, age);
        newUser.Next = head;
        head = newUser;
    }

    public UserNode? FindUserById(int userId)
    {
        UserNode? temp = head;
        while (temp != null)
        {
            if (temp.UserId == userId) return temp;
            temp = temp.Next;
        }
        return null;
    }

    public bool AddFriendConnection(int userId1, int userId2)
    {
        UserNode? u1 = FindUserById(userId1);
        UserNode? u2 = FindUserById(userId2);
        if (u1 == null || u2 == null) return false;

        if (!u1.FriendIds.Contains(userId2)) u1.FriendIds.Add(userId2);
        if (!u2.FriendIds.Contains(userId1)) u2.FriendIds.Add(userId1);
        return true;
    }

    public bool RemoveFriendConnection(int userId1, int userId2)
    {
        UserNode? u1 = FindUserById(userId1);
        UserNode? u2 = FindUserById(userId2);
        if (u1 == null || u2 == null) return false;

        u1.FriendIds.Remove(userId2);
        u2.FriendIds.Remove(userId1);
        return true;
    }

    public void DisplayUserFriends(int userId)
    {
        UserNode? user = FindUserById(userId);
        if (user == null)
        {
            Console.WriteLine($"User ID {userId} not found.");
            return;
        }
        Console.WriteLine($"Friends of {user.Name} (ID: {user.UserId}):");
        foreach (int fid in user.FriendIds)
        {
            UserNode? f = FindUserById(fid);
            if (f != null)
            {
                Console.WriteLine($"- {f.Name} (ID: {f.UserId})");
            }
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        UserNode? u1 = FindUserById(userId1);
        UserNode? u2 = FindUserById(userId2);
        if (u1 == null || u2 == null) return;

        Console.WriteLine($"Mutual Friends between {u1.Name} and {u2.Name}:");
        bool any = false;
        foreach (int fid in u1.FriendIds)
        {
            if (u2.FriendIds.Contains(fid))
            {
                UserNode? m = FindUserById(fid);
                if (m != null)
                {
                    Console.WriteLine($"- {m.Name} (ID: {m.UserId})");
                    any = true;
                }
            }
        }
        if (!any) Console.WriteLine("No mutual friends found.");
    }
}

public class SocialMediaFriendLinkedList
{
    public static void Run()
    {
        Console.WriteLine("--- Singly Linked List: Social Media Friend Connections ---");

        SocialMediaGraphLinkedList network = new SocialMediaGraphLinkedList();
        network.AddUser(1, "Alice", 24);
        network.AddUser(2, "Bob", 25);
        network.AddUser(3, "Charlie", 23);
        network.AddUser(4, "Diana", 26);

        network.AddFriendConnection(1, 2);
        network.AddFriendConnection(1, 3);
        network.AddFriendConnection(2, 3);
        network.AddFriendConnection(3, 4);

        network.DisplayUserFriends(1);
        Console.WriteLine();
        network.FindMutualFriends(1, 2);
    }
}
