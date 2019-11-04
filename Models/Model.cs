using System;

namespace viewmodelfun.Models
{
    public class Model { }

    public class Number
    {
        public int num { get; set; }
    }
    public class Message
    {
        public string MessageContent { get; set; }
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class SingleUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}