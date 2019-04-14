using System;
using System.Text;

namespace StringDrill
{
    class Program
    {
        static void Main()
        {
            String one = "A Passage";
            String two = "From";
            String three = "The Hobbit";
            String space = " ";
            Console.WriteLine(one + space + two + space + three);
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("\"Good morning!\" he said at last. \"We don't want any adventures here, thank you!");
            paragraph.Append("You might try over The Hill or across The Water.\" By this he meant that the conversation was at an end.");
            paragraph.Append("\"What a lot of things you do use Good morning for!\" said Gandalf.");
            paragraph.Append("\"Now you mean that you want to get rid of me, and that it won't be good till I move off.\"");
            Console.WriteLine(paragraph);
            Console.Read();
        }
    }
}
