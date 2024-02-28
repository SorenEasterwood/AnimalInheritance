namespace AnimalInheritance
{
    internal class Program
    {
        class Animal
        {
            private string name; // only accessible within this class
            protected string type; //accessible from derived classes
            public string color;  // accessible from any class

            public void setName(string name)
            {
                this.name = name;
            }
            public virtual string getName()
            {
                return this.name;
            }
            public void setType(string type)
            {
                this.type = type;
            }
            public virtual string getType()
            {
                return this.type;
            }
        }

        class Penguin : Animal 
        {
            public string sex;
            public int age;
            public string location;

            public override string getName()
            {
                return base.getName();
            }

            public override string getType()
            {
                return base.getType(); 
            }


        }


        static void Main(string[] args)
        {
            Animal loony = new Animal();
            loony.setName("Porky");
            loony.setType("pig");
            // color is a public field and can be accessed anywhere
            loony.color = "pink";

            Console.WriteLine("Animal Information...");
            Console.WriteLine($"My name is {loony.getName()}");
            Console.WriteLine($"I am a {loony.getType()}");
            Console.WriteLine($"I am a lovely {loony.color} color");
            Console.WriteLine();

            Penguin popper = new Penguin();
            popper.setName("Popper");
            popper.setType("Emperor");
            popper.color = "Black";
            popper.sex = "Male";
            popper.age = 11;
            popper.location = "Antartica";

            Console.WriteLine("Penguin Information...");
            Console.WriteLine($"My name is {popper.getName()}");
            Console.WriteLine($"I am a(n) {popper.getType()} Penguin");
            Console.WriteLine($"I am a lovely {popper.color} color");
            Console.WriteLine($"I am {popper.age} years old");
            Console.WriteLine($"I live in {popper.location}.");

            Console.ReadLine();
        }
    }
}
