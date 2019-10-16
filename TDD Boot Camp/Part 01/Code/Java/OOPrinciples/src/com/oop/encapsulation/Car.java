package com.oop.encapsulation;

public class Car {
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
}
