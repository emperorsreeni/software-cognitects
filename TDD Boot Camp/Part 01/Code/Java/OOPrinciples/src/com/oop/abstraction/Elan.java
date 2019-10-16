package com.oop.abstraction;


import java.time.LocalDate;
import java.time.Duration;
public class Elan {
	public String firstName;
	public String lastName;
	public LocalDate  dateOfBirth;

	public Elan() {
		this.firstName = "Elan";
		this.lastName = "Sreenivasan";
		this.dateOfBirth = LocalDate.of(2018, 11, 13);
	}
	
	public int getAge() {
		return calculateAge();
	}
	
	public int calculateAge() {
		long duration =  Duration.between(LocalDate.now(), this.dateOfBirth).getSeconds();
		return (int)(duration/(60*60*24*365));
	}
}
