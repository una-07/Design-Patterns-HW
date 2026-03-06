using System;

class Program
{
    static void Main()
    {
        ChatRoom chat = new ChatRoom();

        User user1 = new User("Ali", chat);
        User user2 = new User("Dana", chat);
        User user3 = new User("Nursultan", chat);

        chat.AddUser(user1);
        chat.AddUser(user2);
        chat.AddUser(user3);

        user1.Send("Привет всем!");
        user2.Send("Привет!");
    }
}
