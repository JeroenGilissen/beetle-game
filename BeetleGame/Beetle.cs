using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BeetleGame
{
    public class Beetle
    {
        // De visuele ellipse die de kever voorstelt op de canvas
        private Ellipse _shape;

        // Bewegingssnelheid van de kever
        public double Speed { get; set; }

        // Diameter van de ellipse in pixels
        public int Size { get; set; }

        // Horizontale positie van het middelpunt
        public int X { get; set; }

        // Verticale positie van het middelpunt
        public int Y { get; set; }

        // Beweegt de kever naar rechts (true) of links (false)
        public bool Right { get; set; }

        // Beweegt de kever omhoog (true) of omlaag (false)
        public bool Up { get; set; }

        // Geeft aan of de kever zichtbaar is op de canvas
        public bool IsVisible { get; set; }

        /// <summary>
        /// Maakt een nieuwe kever aan en plaatst deze op de canvas.
        /// </summary>
        /// <param name="canvas">De canvas waarop de kever getekend wordt</param>
        /// <param name="x">X-coördinaat van het middelpunt</param>
        /// <param name="y">Y-coördinaat van het middelpunt</param>
        /// <param name="size">Grootte (diameter) van de kever</param>
        public Beetle(Canvas canvas, int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;

            // Kever start bewegend naar rechts en omhoog
            Up = true;
            Right = true;

            // Ellipse aanmaken met de opgegeven grootte en kleur
            _shape = new Ellipse
            {
                Width = size,
                Height = size,
                Fill = Brushes.SaddleBrown,

                // Margin positioneert de linkerbovenhoek zodat het middelpunt op (x, y) valt
                Margin = new Thickness(x - size / 2, y - size / 2, 0, 0)
            };

            // Ellipse toevoegen aan de canvas zodat hij zichtbaar wordt
            canvas.Children.Add(_shape);
        }
    }
}