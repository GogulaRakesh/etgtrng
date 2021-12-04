package com.sonata;

public class Twoobject {
	int stdId;
	String stdName;
	String stdClass;
	Twoobject(int id, String name, String Class )
	{
		this.stdId = id;
		this.stdName = name;
		this.stdClass = Class;
	}
	public void display()
	{
		System.out.println(stdId);
		System.out.println(stdName);
		System.out.println(stdClass);
	}
	public static void main(String args[])
	{
		Twoobject s1 = new Twoobject (52,"Rakesh","BTech");
		s1.display();
		Twoobject s2 = new Twoobject (36,"Rachana","Inter");
		s2.display();
	}

}
