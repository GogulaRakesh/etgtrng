package com.sonata;

public class Twolagernumber {
	public static void main(String args[]) {
		int array[]= {23,45,64,73,86,94,88};
		for(int a=0;a<array.length;a++)
		{
			System.out.print(array[a]+" ");
		}
		System.out.println("\n");
		
		int large1 = array[0];
		int large2 = array[1];
		int ref;
		if (large1 < large2)
		{
			ref = large1;
			large1 = large2;
			large2 = ref;
		}
		for (int i=2;i<array.length;i++)
		{
			if (array[i] > large1)
			{
				large2 = large1;
				large1 = array[i];
			}
			else if (array[i] > large2 && array[i] != large1)
			{
				large2 = array[i];
			}
		}
		System.out.println("1st largest is "+large1);
		System.out.println("2rd largest is "+large2);
	}

}
