using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Helper
    {
        public static Points GetPointsByText(string pointsText)
        {
            Points points = new Points();

            var width = 0;
            var height = 0;

            if (!string.IsNullOrWhiteSpace(pointsText))
            {
                var areaArray = pointsText.Split(Common.Separator.CORDINANT_SEPARATOR);
                var count = areaArray.Length;

                if (count > 1)
                {
                    if (int.TryParse(areaArray[0], out width))
                        points.X = width;

                    if (int.TryParse(areaArray[1], out height))
                        points.Y = height;

                    if (count > 2)
                    {
                        try
                        {
                            points.Direction = Common.Lookup.StringToDirection[areaArray[2]];
                        }
                        catch
                        {
                        }

                    }
                }
            }

            return points;
        }

        public static Points GetPointsByCommand(Points points, string command)
        {

            if (points == null)
                return new Points();

            if (command.Equals(Common.Command.Move))
            {
                switch (points.Direction)
                {
                    case Common.Direction.North:
                        points.Y += Common.StepValue;
                        break;
                    case Common.Direction.South:
                        points.Y -= Common.StepValue;
                        break;
                    case Common.Direction.East:
                        points.X += Common.StepValue;
                        break;
                    case Common.Direction.West:
                        points.X -= Common.StepValue;
                        break;
                    default:
                        break;
                }
            }
            else if (command.Equals(Common.Command.Left))
            {
                points.Direction = Common.Lookup.LeftCommandToDirection[points.Direction];
            }
            else if (command.Equals(Common.Command.Right))
            {
                points.Direction = Common.Lookup.RightCommandToDirection[points.Direction];
            }

            return points;
        }
    }
}
