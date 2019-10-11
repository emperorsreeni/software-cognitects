package com.oop.abstraction;

import java.time.Duration;
import java.time.LocalDate;

public class Iniyan {
	public String firstName;
	public String lastName;
	public LocalDate  dateOfBirth;

	public Iniyan() {
		this.firstName = "Iniyan";
		this.lastName = "Sreenivasan";
		this.dateOfBirth = LocalDate.of(2015, 11, 13);
	}
	
	public int getAge() {
		return calculateAge();
	}
	
	public int calculateAge() {
		long duration =  Duration.between(LocalDate.now(), this.dateOfBirth).getSeconds();
		return (int)(duration/(60*60*24*365));
	}
}
