package com.oop.telldonotask.good;

public class Tester {
	public Unit convertToCentiMeters() {
		Unit actual = new Unit(10,UnitType.MILIMETERS);
		return actual.convertTo(UnitType.CENTIMETERS);
	}
	public Unit convertToMeters() {
		Unit actual = new Unit(10,UnitType.CENTIMETERS);
		return actual.convertTo(UnitType.METERS);
	}
}
