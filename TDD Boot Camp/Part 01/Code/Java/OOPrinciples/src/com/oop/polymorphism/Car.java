package com.oop.polymorphism;

public class Car implements Exhaustable {
	private Engine engine;
	Car(Engine engine){
		this.engine = engine;
	}
	
    public void startEngine() {
       engine.start();
    }
    public void shutDownEngine() {
    	engine.start();
    }

	@Override
	public void Exhaust() {
		//Do exhaust		
	}
}
