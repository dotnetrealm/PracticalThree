namespace Abstraction
{
    internal class Laptop
    {
        private string _brand = string.Empty;

        private string _model = string.Empty;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// displays laptop details
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }

        /// <summary>
        /// dispalys motherboard information
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
