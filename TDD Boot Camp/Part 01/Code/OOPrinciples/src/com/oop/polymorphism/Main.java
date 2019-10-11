package com.oop.polymorphism;

public class Main {
	public static void main(String[] args) {
		
		//Static Polymorphism
		DieselEngine dieselEngine = new DieselEngine();
		dieselEngine.start();
		
		//Dynamic Polymorphism
		Engine engine = new PetrolEngine();
		engine.start();
		
		Exhaustable exhaustable = new Car(engine);
		exhaustable.Exhaust();
		
		exhaustable = new PowerGenerator();
		exhaustable.Exhaust();
	}
}
