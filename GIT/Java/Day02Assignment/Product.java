package com.sonata;

public class Product 
{
	int proId;
	String proName;
    static double proPrice;
	
	Product(int id,String name,double price)
	{
		this.proId = id;
		this.proName = name;
		this.proPrice = price;
	
	}
	public double Totalbill(double GST) 
	{
		double total=this.proPrice*GST;
		return total;
	}
	
	public void display()
	{
		System.out.println("Productid: "+proId);
		System.out.println("Product name: "+proName);
		System.out.println("Base Price: "+proPrice);
		
	}
	
	public static void main(String args[]) 
	{
		Product p1=new Product(1,"Laptop",44000);
		p1.display();
		double a=p1.Totalbill(0.05);
		System.out.println("TAX :"+a);
		double b=a+proPrice;
		System.out.println("Total bill with tax: "+b);
		
	}

}
	


