using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeFactorization : MonoBehaviour
{
    int[] _primeNumbers;
	[SerializeField] int _listSet = 100;

	private void Start()
	{
		_primeNumbers = new int[_listSet];
		int count = 2;

		for(int i = 0; i < _primeNumbers.Length; i++)
		{
			for(int j = 2; j <= count; j++)
			{

				
			}
		}
	}
}
