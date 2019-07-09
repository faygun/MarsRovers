using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Rover : IRover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public string Direction { get; set; }
        public Rover(IPlateau plateau, string points, string commands)
        {
            if (!checkPlateau(plateau))
                throw new ArgumentOutOfRangeException();

            prepareCoordinate(points);
            
            Move(commands);

            if (XCoordinate > plateau.Width || YCoordinate > plateau.Height)
                throw new ArgumentOutOfRangeException();
        }

        #region private methods
        private bool checkPlateau(IPlateau plateau)
        {
            return plateau != null && plateau.Width > 0 && plateau.Height > 0;
        }

        private void prepareCoordinate(string pointsText)
        {
            var points = Helper.GetPointsByText(pointsText);

            XCoordinate = points.X;
            YCoordinate = points.Y;
            Direction = points.Direction;
        }

        private void Move(string commands)
        {
            if (string.IsNullOrWhiteSpace(commands))
                return;

            foreach (var command in commands.ToCharArray())
            {
                var points = Helper.GetPointsByCommand(new Points
                {
                    X = XCoordinate,
                    Y = YCoordinate,
                    Direction = Direction
                }, command.ToString());

                XCoordinate = points.X;
                YCoordinate = points.Y;
                Direction = points.Direction;
            }
        }
        #endregion
    }
}
