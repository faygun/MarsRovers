using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Common
    {
        public const int StepValue = 1;
        public class Separator
        {
            public const char CORDINANT_SEPARATOR = ' ';
        }

        public class Command
        {
            public const string Left = "L";
            public const string Right = "R";
            public const string Move = "M";
        }
        public class Direction
        {
            public const string North = "N";
            public const string South = "S";
            public const string East = "E";
            public const string West = "W";
        }
        public class Lookup
        {
            public static Dictionary<string, string> LeftCommandToDirection = new Dictionary<string, string>
            {
                {
                    Direction.North,Direction.West
                },
                {
                    Direction.West,Direction.South
                },
                {
                    Direction.South,Direction.East
                },
                {
                    Direction.East,Direction.North
                }
            };
            public static Dictionary<string, string> RightCommandToDirection = new Dictionary<string, string>
            {
                {
                    Direction.North,Direction.East
                },
                {
                    Direction.East,Direction.South
                },
                {
                    Direction.South,Direction.West
                },
                {
                    Direction.West,Direction.North
                }
            };
            public static Dictionary<string, string> StringToDirection = new Dictionary<string, string>
            {
                {
                    "S", Direction.South
                },
                {
                    "N", Direction.North
                },
                {
                    "E", Direction.East
                },
                {
                    "W", Direction.West
                },
            };

            public static Dictionary<string, string> StringToCommand = new Dictionary<string, string>
            {
                {
                    "M", Command.Move
                },
                {
                    "L", Command.Left
                },
                {
                    "R", Command.Right
                }
            };
        }
    }
}
