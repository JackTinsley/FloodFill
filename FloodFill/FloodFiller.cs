using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FloodFillTests
{
    public class FloodFiller
    {
        private readonly List<string> m_Image;

        public FloodFiller(List<string> image)
        {
            m_Image = image;
        }

        public List<string> Fill(Point coords, char character, bool wrap)
        {
            var originalCharacter = GetCharacter(coords);
            return ReallyFill(coords, character, originalCharacter, wrap);
        }

        private char GetCharacter(Point coords)
        {
            return m_Image[coords.Y][coords.X];
        }

        private List<string> ReallyFill(Point coords, char fillCharacter, char originalCharacter, bool wrap)
        {
            var currentCharacter = GetCharacter(coords);
            if (currentCharacter == originalCharacter)
            {
                SetCharacter(coords, fillCharacter);

                GetAdjacent(coords, wrap).ToList().ForEach(adjacentCoords =>
                    ReallyFill(adjacentCoords, fillCharacter, originalCharacter, wrap));
            }

            return m_Image;
        }

        private IEnumerable<Point> GetAdjacent(Point coords, bool wrap)
        {
            var adjacentPoints = new List<Point>() 
            {
               new Point(coords.X - 1, coords.Y),
               new Point(coords.X + 1, coords.Y),
               new Point(coords.X, coords.Y + 1),
               new Point(coords.X, coords.Y - 1)
            };

            foreach (var adjacentPoint in adjacentPoints)
            {
                if (wrap) yield return WrapBounds(adjacentPoint);
                else if (IsWithinBounds(adjacentPoint)) yield return adjacentPoint;
            }
        }

        private Point WrapBounds(Point adjacentPoint)
        {
            if (adjacentPoint.X < 0) adjacentPoint.X = m_Image[0].Length-1;
            else if (adjacentPoint.X >= m_Image[0].Length) adjacentPoint.X = 0;

            if (adjacentPoint.Y < 0) adjacentPoint.Y = m_Image.Count-1;
            else if (adjacentPoint.Y >= m_Image.Count) adjacentPoint.Y = 0;

            return adjacentPoint;
        }

        private bool IsWithinBounds(Point adjacentPoint) =>
            (adjacentPoint.X >= 0
            && adjacentPoint.X < m_Image[0].Length
            && adjacentPoint.Y >= 0
            && adjacentPoint.Y < m_Image.Count);

        private void SetCharacter(Point coords, char character)
        {
            var row = m_Image[coords.Y].ToCharArray();
            row[coords.X] = character;
            m_Image[coords.Y] = new string(row);
        }

    }
}