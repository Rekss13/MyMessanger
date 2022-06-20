using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("RusAl", "Privet", DateTime.UtcNow);

            string serializedMessage = JsonConvert.SerializeObject(message);
            Console.WriteLine(serializedMessage);

            Message deserializedMessage = JsonConvert.DeserializeObject<Message>(serializedMessage);
            Console.WriteLine(deserializedMessage);

            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-06-20T20:38:43.0408771Z"}
            //RusAl < 20.06.2022 20:38:43 >: Privet
        }
    }
}
