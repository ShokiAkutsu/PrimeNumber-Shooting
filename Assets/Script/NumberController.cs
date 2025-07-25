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
		//呼び出されたときに、入力されていた値をもらう　もしくは、弾に数値を持たせておく？
		int index = _primeNumber.Factorization(_number, -9999);
		
		if(index != _number)
		{
			//出来たら、入力した数字を保持　そして、PrimeBlockを生成
			//もしくは、PrimeBlock専用の保持スクリプトを作ってもいいのかも？↑で作るかPrimeBlock
			//で、これの代わりに別のスクリプトをアタッチすることで問題クリアできるのでは？
			_number = index;
		}
	}
}
