namespace DotNetEsercizio.Core
{
    public class Square:IShape
    {
        public int Height { get ; set ; }
        public int Width { get ; set ; }

        public Square(int length)
        {
            this.Height = length;
            this.Width = length;
        }
    }
}