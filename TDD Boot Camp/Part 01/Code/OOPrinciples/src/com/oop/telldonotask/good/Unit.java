package com.oop.telldonotask.good;

public class Unit {
	private double value;
	private UnitType unitType;
	public Unit(double value,UnitType unitType) {
		this.value = value;
		this.setUnitType(unitType);
	}
	public double getValue() {
		return value;
	}

	public void setValue(double value) {
		this.value = value;
	}
	public UnitType getUnitType() {
		return unitType;
	}
	public void setUnitType(UnitType unitType) {
		this.unitType = unitType;
	}
	
	public Unit convertTo(UnitType unitType) {
		//check the source unit type
		//convert to destination unit type
		
		//dummy return
		return new Unit(10,unitType);
	}
	
}
