package com.sonata;

public class Tshirt {
	String color;
	String material;
	String design;
	String Size;
	
	public Tshirt(String cl,String mt,String de,String si) 
	{
	this.color = cl;
	this.material = mt;
	this.design = de;
	this.Size = si;
	}
	
	public void small() 
	{
		
		System.out.println("This is Small size");
		
	}
	
	public void Medium() 
	{
		System.out.println("This is  medium size");
		
	}
	public void Large() 
	{
		System.out.println("This is Large size");
	}
	
	public void display() 
	{
		System.out.println("Color: "+color);
		System.out.println("Material: "+material);
		System.out.println("Design: "+design);
		System.out.println("Size: "+Size);
				
	}
	
	public static void main(String args[]) 
	{
		Tshirt t1=new Tshirt("Blue","cotton","Fullsleave","S");
		t1.display();
		t1.small();
		Tshirt t2=new Tshirt("Pink","cotton","sleaveless","L");
		t2.display();
		t2.Medium();
		Tshirt t3=new Tshirt("Sky Blue","cotton","Fullsleave","XL");
		t3.display();
		t3.Large();
	}

}
