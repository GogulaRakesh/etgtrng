package com.sonata;

public class MyOwnAutoShop {
	public static void main(String args[])
	{
		Car c = new Car(5000,1500000,"Blue");
		Sedan s = new Sedan(2000,450000,"Sky Blue",45);
		Ford f1 = new Ford(1543,770000,"White",2020,54);
		Ford f2 = new Ford(3670,880000,"Red",2021,3);
		System.out.println("Car");
		c.display();
		System.out.println("Sale Price of Car:" +c.getSalePrice());
		System.out.println("Sedan");
		s.display();
		System.out.println(s.length);
		System.out.println("Sale Price of Sedan:" +s.getSalePrice());
		System.out.println("Ford 1");
		f1.display();
		System.out.println(f1.year);
		System.out.println(f1.manufacturerDiscount);
		System.out.println("Sale Price of ford1:" +f1.getSalePrice());
		System.out.println("Ford 2");
		f2.display();
		System.out.println(f2.year);
		System.out.println(f2.manufacturerDiscount);
		System.out.println("Sale Price of ford2:" +f2.getSalePrice());
	}


}
