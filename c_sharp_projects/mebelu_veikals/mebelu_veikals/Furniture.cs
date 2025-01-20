namespace mebelu_veikals
{
    public class Furniture
    {
        public string Name;
        public string Description;
        public double Price;
        public int Length;
        public int Width;
        public int Height;
        public Furniture(string name, string description, double price, int length, int width, int height)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
    }
}