using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumberProduct : MonoBehaviour
{
    List<int> _primeNumbers = new List<int>();
	public List<int> PrimeNumbers => _primeNumbers;

	[SerializeField] int _max = 1000;		//レベルデザインでも使えるかも

	private void Start()
	{
		for(int i = 2; i < _max; i++)
		{
			bool isPrime = true;

			for(int j = 2; j * j <= i; j++)
			{
				if(i % j == 0)
				{
					isPrime = false;
					break;
				}
			}
			if(isPrime) _primeNumbers.Add(i);
		}

		foreach(int i in _primeNumbers) Debug.Log(i);
	}

	public int RandomProduct()
	{
		//出力した数で生み出す数を大きくしたり、少し増減したいint Countを外に置く
		//_maxまで達したらレベルマックスになるように
		int number = 1;
		int take = Random.Range(1, 10); //レベルで変化できるようにしたい
		int limit = _primeNumbers.Count;
		int million = 1000000;

		for (int i = 0; i < take; i++)
		{
			bool nextMillion = true;
			int n = Random.Range(0, limit); //始めは小さい数からにしたい 徐々に増やす
			number *= _primeNumbers[n];

			for(int p = 0; p < limit; p++)
			{
				if((number * _primeNumbers[p]) / million == 0)
				{
					limit = p + 1;
					break;
				}
				else nextMillion = false;
			}
			//どれをかけても積が100万の位を突破したら終わりにする
			if(nextMillion) break;
		}
		//戦略として、いくらか減らしたら敵を倒しやすくなるをしたいので
		//if(true) number += Random.Range(-3, 3); //ここでランダムで増減したい(最初から使うべきかは考え中)

		return number;
	}

	public int Factorization(int Origin, int Factor)
	{
		if(Origin % Factor == 0)
		{
			return Origin / Factor;
		}
		else
		{
			return Origin;
		}
	}

	public bool IsPrime(int value)
	{
		foreach(int prime in _primeNumbers)
		{
			if(prime == value) return true;
		}

		return false;
	}
}
