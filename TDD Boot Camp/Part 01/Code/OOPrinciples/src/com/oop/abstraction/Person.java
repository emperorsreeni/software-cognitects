package com.oop.abstraction;

import java.time.Duration;
import java.time.LocalDate;

public class Person {
	public String firstName;
	public String lastName;
	public LocalDate  dateOfBirth;
	
	public int getAge() {
		return calculateAge();
	}
	
	int calculateAge() {
		long duration =  Duration.between(LocalDate.now(), this.dateOfBirth).getSeconds();
		return (int)(duration/(60*60*24*365));
	}
}
