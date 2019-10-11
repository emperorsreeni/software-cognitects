package com.oop.abstraction;

public class Reactangle {
	private Size size;
	private Point point;
	Reactangle(Point point, Size size){
		this.point = point;
		this.size = size;
	}
	public Point getPoint() {
		return point;
	}
	public Size getSize() {
		return size;
	}
}