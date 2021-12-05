package com.sonata;

public class Trunk extends Car {

	int weight;
	Trunk(int speed,double regularPrice,String color,int weight)
	{
		super(speed,regularPrice,color);
		this.weight = weight;
	}
	public double getSalePrice()
	{
		super.getSalePrice();
		if(weight>2000)
		{
			return this.getSalePrice()-(this.getSalePrice()*0.4);
		}
		else
		{
			return this.getSalePrice()-(this.getSalePrice()*0.5);
		}
	}

}
