using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumberProduct : MonoBehaviour
{
    List<int> _primeNumbers = new List<int>();
	public List<int> PrimeNumbers => _primeNumbers;

	[SerializeField] int _max = 1000;		//���x���f�U�C���ł��g���邩��

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
		//�o�͂������Ő��ݏo������傫��������A��������������int Count���O�ɒu��
		//_max�܂ŒB�����烌�x���}�b�N�X�ɂȂ�悤��
		int number = 1;
		int take = Random.Range(1, 10); //���x���ŕω��ł���悤�ɂ�����
		int limit = _primeNumbers.Count;
		int million = 1000000;

		for (int i = 0; i < take; i++)
		{
			bool nextMillion = true;
			int n = Random.Range(0, limit); //�n�߂͏�����������ɂ����� ���X�ɑ��₷
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
			//�ǂ�������Ă��ς�100���̈ʂ�˔j������I���ɂ���
			if(nextMillion) break;
		}
		//�헪�Ƃ��āA�����炩���炵����G��|���₷���Ȃ���������̂�
		//if(true) number += Random.Range(-3, 3); //�����Ń����_���ő���������(�ŏ�����g���ׂ����͍l����)

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
