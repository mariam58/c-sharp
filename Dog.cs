namespace c_sharp
{
    public class Dog
    {
        public static void Dogs()
        {
            List<DogModel> dogs = new List<DogModel>();

            DogModel dog1 = new DogModel("Bull Terrier", 1.34d, 35d, "long");
            DogModel dog2 = new DogModel("Staffy", 2.34d, 35.4d, "short");
            var dog3 = new DogModel("Cane Corso", 2.34d, 35.4d, "short");
            var dog4 = new DogModel("beagles", 2.34d, 35.4d, "short");

            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);

            foreach (var item in dogs)
            {
                if (item.Breed == "Bull Terrier")
                {
                    Console.WriteLine("გრძელი სახე, მოკლე ბეწვი, ცოტა შეუხედავი");
                }
                if (item.Breed == "Staffy")
                {
                    Console.WriteLine("მოკლე სახე, მოკლე ბეწვი, ლამაზი");
                }
                Console.WriteLine(item.Breed);
                Console.WriteLine(item.Height);
                Console.WriteLine(item.Weight);
                Console.WriteLine(item.Fur);
            }
        }
    }
    public class DogModel
    {
        public string Breed { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Fur { get; set; }

        public DogModel(string breed, double height, double weight, string fur)
        {
            Breed = breed;
            Height = height;
            Weight = weight;
            Fur = fur;
        }
    }
}