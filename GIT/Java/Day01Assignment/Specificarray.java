package com.sonata;

public class Specificarray {
	public static void main (String agrs[])
{
	int array[] = {1,2,3,4,5,6,7,8};
	int i=5;
	int r;
	for(r=0;r<8;r++)
	{
		if(array[r]==i)
		{
			System.out.println("Value is there");
		}
		if(r==8)
		{
			System.out.println("Value id not there");
		}
	}
}
}
