using System;

namespace Graph
{
    public class Vertex
    {
        public Vertex(int number)
        {
            Number = number;
        }

        public int Number { get; set; }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
