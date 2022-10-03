namespace Defining
{
    public class Publication
    {
        private string _name;
        public Publication(string name, int pagecount, decimal price)
        {
            _name = name;
            Pagecount = pagecount;
            Price = price;
        }
        // The PageCount property has no backing field
        public int Pagecount
        {
            get; set;
        }
        public decimal Price
        {
            get; set;

        }
        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be blank!");
                }
                _name = value;
            }
        }

        // TODO: use ther "virtual" keyword to indicate that a method can be overridden by subclass to customize their behaviour
        public virtual string GetDescription(){
            return $"{Name},{Pagecount}, {Price}";
        }
    }
}