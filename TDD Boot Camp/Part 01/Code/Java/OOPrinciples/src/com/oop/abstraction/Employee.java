package com.oop.abstraction;

public class Employee
{
	private String name;
	private String id;
	private double salary;
	private String departmentName;
	public Employee(String name, String id, double salary,String departmentName)
	{
		this.name = name;
		this.id = id;
		this.salary = salary;
		this.departmentName = departmentName;
	}
	public String getName()
	{
		return name;
	}
	public String getId()
	{
		return id;
	}
	public Double getSalary()
	{
		return salary;
	}
	public String getDepartment() {
		return departmentName;
	}
}