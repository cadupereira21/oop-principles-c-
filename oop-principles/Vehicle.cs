namespace oop_principles {
    public abstract class Vehicle {
        public string make { get; protected set; }
        
        public string model { get; protected set; }

        public int year {
            get => year;
            protected set {
                if (value < 1950 || value > 9999) {
                    throw new System.ArgumentException("Year must be between 1950 and 2022");
                }
                
                year = value;
            }
        }

        public string color { get; protected set; }

        public string licensePlate { get; protected set; }
        
        public string owner { get; protected set; }

        public string name {
            get => $"{make} {model} {year}";
            set => name = value;
        }
        
        public Vehicle(string make, string model, int year, string color, string licensePlate, string owner) {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.licensePlate = licensePlate;
            this.owner = owner;
        }
        
        public void Start() {
            System.Console.WriteLine("Vehicle started");
        }
        
        public void Stop() {
            System.Console.WriteLine("Vehicle stopped");
        }
        
        public void Accelerate() {
            System.Console.WriteLine("Vehicle accelerated");
        }
        
        public void Brake() {
            System.Console.WriteLine("Vehicle braked");
        }
        
        public void Turn(string direction) {
            System.Console.WriteLine($"Vehicle turned {direction}");
        }

        public abstract void MakeNoise();
    }
}