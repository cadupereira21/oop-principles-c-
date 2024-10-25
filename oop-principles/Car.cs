namespace oop_principles {
    // INHERITANCE
    public class Car : Vehicle{
        
        // ENCAPSULATION
        private int _numberOfDoors;

        public Car(string make, string model, int year, string color, string licensePlate, string owner, int numberOfDoors) :
            base(make, model, year, color, licensePlate, owner) {
            this._numberOfDoors = numberOfDoors;
        }
        
        // POLYMORPHISM
        public override void MakeNoise() {
            // ABSTRACTION
            PressHonk();
        }
        
        private static void PressHonk() {
            System.Console.WriteLine("Honk honk");
        }
    }
}