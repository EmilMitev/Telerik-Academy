using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Copy from here https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exam/2014/Problem%203%20-%20Data%20Structures%20(Doncho)/Solution/Command.cs
namespace UnitsOfWork
{
    public enum CommandType
    {
        Add,
        Remove,
        Find,
        Power,
        End
    }

    public class Command
    {
        public CommandType Type { get; set; }

        public string Params { get; set; }

        public static Dictionary<string, CommandType> stringToCommandType;

        static Command()
        {
            stringToCommandType = new Dictionary<string, CommandType>();

            stringToCommandType["add"] = CommandType.Add;
            stringToCommandType["remove"] = CommandType.Remove;
            stringToCommandType["find"] = CommandType.Find;
            stringToCommandType["power"] = CommandType.Power;
            stringToCommandType["end"] = CommandType.End;

        }

        public static Command ParseCommand(string input)
        {
            foreach (var pair in stringToCommandType)
            {
                if (input.StartsWith(pair.Key))
                {
                    return new Command()
                    {
                        Type = pair.Value,
                        Params = input.Substring(pair.Key.Length).Trim()
                    };
                }
            }
            return null;
        }
    }
}