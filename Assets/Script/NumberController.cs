using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
	int _number;
	TextMesh _text;
	PrimeNumberProduct _primeNumber;

	void Start()
	{
		_text = GetComponent<TextMesh>();
		_primeNumber = GameObject.Find("PrimeNumber").GetComponent<PrimeNumberProduct>();
		_number = _primeNumber.RandomProduct();
	}

	void Update()
	{
		_text.text = _number.ToString();
	}

	public void Subtract()
	{
		_number--;

		if (_number <= 0)
		{
			Destroy(transform.parent.gameObject);
		}
	}

	public void PrimeFactorization()
	{
		//�Ăяo���ꂽ�Ƃ��ɁA���͂���Ă����l�����炤�@�������́A�e�ɐ��l���������Ă����H
		int index = _primeNumber.Factorization(_number, -9999);
		
		if(index != _number)
		{
			//�o������A���͂���������ێ��@�����āAPrimeBlock�𐶐�
			//�������́APrimeBlock��p�̕ێ��X�N���v�g������Ă������̂����H���ō�邩PrimeBlock
			//�ŁA����̑���ɕʂ̃X�N���v�g���A�^�b�`���邱�ƂŖ��N���A�ł���̂ł́H
			_number = index;
		}
	}
}
