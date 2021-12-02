package com.sonata;

public class Hifhestcount {
	public static void main(String args[]) {
		int count=0;
		int arr[]= {5,1,2,3,4,5,6,7,3,6,4,5};
		for(int i=0;i<arr.length;i++)
		{
			System.out.print(arr[i]+" ");
		}
		
		System.out.println("\n");
		for (int a=0;a<arr.length;a++)
		{
			for (int b=a+1;b<arr.length;b++)
			{
				if ( arr[a] == arr[b] )
				{
					System.out.print(arr[b]+" ");
					count++;
				}
			}
		}
		System.out.println("\n");
				System.out.println("Highest count of duplicates are "+count);
	}

}
