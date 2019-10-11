package com.oop.polymorphism;

public abstract class Engine {
	public boolean isRunning;
	public void start() {
		this.isRunning = true;
	}
	public void stop() {
		this.isRunning = false;
	}
}
