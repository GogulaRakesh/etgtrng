package com.sonata;

public class Duplicatenumber {
	public static void main(String args[])
	{
		int[] arr = new int [] {1,2,3,4,2,7,8,8,3,4};
		int i,j;
		for(i=0;i<arr.length;i++)
			for(j=i+1;j<arr.length;j++)
			{
				if(arr[i] == arr[j])
					System.out.println(arr[j]);
			}
	}

}
