namespace oop_principles {
    public class Motorcycle : Vehicle {
        public Motorcycle(string make, string model, int year, string color, string licensePlate, string owner) : base(make, model, year, color, licensePlate, owner) { }
        
        public override void MakeNoise() {
            System.Console.WriteLine("Vroom vroom");
        }
    }
}