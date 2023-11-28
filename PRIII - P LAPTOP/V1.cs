using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII___P_LAPTOP
{
    internal class V1
    {
       public class Message
        {
            public string Text { get; set; }
            public int Severity { get; set; }

        }
        public interface ILogger
        {
            public List<Message> Messages { get; set; }
            public void Log(Message message);
            public void Dump();
        }
        public class FileLogger : ILogger
        {
           public List<Message> Messages { get; set; }

            public FileLogger()
            {
                Messages=new List<Message>();
            }
            public void Dump()
            {
                for(int i=0; i<Messages.Count; i++)
                {
                    if (Messages[i].Severity == 0)
                        Console.ForegroundColor = ConsoleColor.White;
                    else if (Messages[i].Severity == 1)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Messages[i].Text);
                    Console.ForegroundColor=ConsoleColor.White;
                }
            }

            public void Log(Message message)
            {
                Messages.Add(message);
            }
        }

        public class DBLogger : ILogger 
        {
            public List<Message> Messages { get; set; }

            public DBLogger()
            {
                Messages=new List<Message>();
            }
            public void Dump()
            {
                for (int i = 0; i < Messages.Count; i++)
                {
                    if (Messages[i].Severity == 0)
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else if (Messages[i].Severity == 1)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Messages[i].Text);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

           public void Log(Message message)
            {
                Messages.Add(message);
            }
        }
        public static void Pokreni()
        {

            Message messageInfo=new Message() { Text="This is info", Severity=0};
            Message messageWarning = new Message() { Text = "This is warning ", Severity = 1 };
            Message messageError = new Message() { Text = "This is Error", Severity = 2 };


            List<Message> messages = new List<Message>()
            {
                messageInfo, messageWarning, messageError  
            
            };


            List<ILogger> loggers = new List<ILogger>()
            {
                new DBLogger(),
                new FileLogger()
            };

            var dblogger = loggers[0];
            var filelogger = loggers[1];
            for(int i=0;i<messages.Count;i++) 
            {
                if (messages[i].Severity >1)
                    filelogger.Log( messages[i]);
                else 
                    dblogger.Log(messages[i] );
            }
            Dump(loggers);
       


            //string str = "ABCDEFGHIJKLMNOPRSTUVZYWXYQ";
            //Random rnd=new Random();

            //List<ConsoleColor> colors = new List<ConsoleColor>()
            //{
            //    ConsoleColor.Green,
            //    ConsoleColor.DarkGray,
            //    ConsoleColor.Gray,
            //    ConsoleColor.Magenta,
            //    ConsoleColor.Blue,
            //    ConsoleColor.Yellow,
            //    ConsoleColor.DarkRed,
            //    ConsoleColor.DarkBlue,
            //};

            //for(int i=0; i < 20; i++) 
            //{
            //    for(int j=0; j < 20; j++) 
            //    {
            //        Console.SetCursorPosition(i, j);
            //        Console.ForegroundColor = colors[rnd.Next(colors.Count)];
            //        Console.WriteLine(str[rnd.Next(0, str.Length)]);
            //    }
            //}
            //while (true)
            //{
            //    Console.CursorVisible = false;
            //    Console.SetCursorPosition(rnd.Next(0, 20),rnd.Next(0,20));
            //    Console.ForegroundColor = colors[rnd.Next(colors.Count)];
            //    Console.WriteLine(str[rnd.Next(0, str.Length)]);
            //    Thread.Sleep(50);

            //}

            //while(true)
            //{
            //    var Inputkey = Console.ReadKey();
            //    if(Inputkey.Key==ConsoleKey.UpArrow)
            //    {
            //        var currentPosition=Console.GetCursorPosition();
            //        if (currentPosition.Top - 1 >= 0)
            //        {
            //            Console.SetCursorPosition(currentPosition.Left, currentPosition.Top - 1);
            //        }
            //    }
            //    if (Inputkey.Key == ConsoleKey.DownArrow)
            //    {
            //        var currentPosition = Console.GetCursorPosition();
            //        Console.SetCursorPosition(currentPosition.Left, currentPosition.Top + 1);

            //    }
            //    if (Inputkey.Key == ConsoleKey.LeftArrow)
            //    {
            //        var currentPosition = Console.GetCursorPosition();
            //        if (currentPosition.Left - 1 >= 0)
            //        {
            //            Console.SetCursorPosition(currentPosition.Left-1, currentPosition.Top);
            //        }

            //    }
            //    if (Inputkey.Key == ConsoleKey.RightArrow)
            //    {
            //        var currentPosition = Console.GetCursorPosition();

            //            Console.SetCursorPosition(currentPosition.Left + 1, currentPosition.Top);
            //    }
            //}
        }


        static void Dump(List<ILogger> loggers)
        {
            for (int i = 0; i < loggers.Count; i++)
            {
                loggers[i].Dump();
            }
        }

    }
}
