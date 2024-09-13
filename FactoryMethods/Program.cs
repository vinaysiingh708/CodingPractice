using System;
namespace FactoryDesignPattern
{
    // What is Factory Design Pattern in C#?

    //A factory is a class with a method.
    //That method creates and returns different objects based on the received input parameter.

    //•	Use Cases : When the object creation is simple and doesn't require a complex decision-making process.


    //Define the Product Interface
    public interface INotificationSender
    {
        void SendNotification(string message);
    }

    //Concrete Implementations for the Products
    public class EmailNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending EMAIL notification: {message}");
            // Logic to send email here...
        }
    }

    public class SMSNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: {message}");
            // Logic to send SMS here...
        }
    }

    public class PushNotification : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending PUSH notification: {message}");
            // Logic to send push notification here...
        }
    }

    //Factory Class to Produce the Products
    public static class NotificationFactory
    {        
        public static INotificationSender CreateNotificationSender(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }

    // Testing the Factory Design Pattern
    public class Program
    {
        public static void Main()
        {
            INotificationSender notificationSender;

            notificationSender = NotificationFactory.CreateNotificationSender("email");
            notificationSender.SendNotification("This is an email notification!");

            notificationSender = NotificationFactory.CreateNotificationSender("sms");
            notificationSender.SendNotification("This is an SMS notification!");

            notificationSender = NotificationFactory.CreateNotificationSender("push");
            notificationSender.SendNotification("This is a push notification!");

            // As with other factory examples, adding new notification methods 
            // would only require extending the factory, without altering the client code.

            Console.ReadKey();
        }
    }
}