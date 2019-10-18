package com.oop.telldonotask.bad;

public class Tester {
	public Unit convertToCentiMeters() {
		Unit actual = new Unit(10);
		double value = actual.getValue();
		double convertedValue = value/100;
		Unit converted = new Unit(convertedValue);
		return converted;
	}
	public Unit convertToMeters() {
		Unit actual = new Unit(10);
		double value = actual.getValue();
		double convertedValue = value/10000;
		Unit converted = new Unit(convertedValue);
		return converted;
	}
}
