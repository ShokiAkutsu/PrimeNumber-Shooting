using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrimeBulletValue : MonoBehaviour
{
	[SerializeField] TextMeshPro _valueText;
	PrimeNumberProduct _product;
	int _currentValue = 0;
	bool _isShoot = false;

	private void Start()
	{
		_product = GameObject.Find("PrimeNumber").GetComponent<PrimeNumberProduct>();
	}

	void Update()
	{
		for (KeyCode key = KeyCode.Alpha0; key <= KeyCode.Alpha9; key++)
		{
			if (Input.GetKeyDown(key) && _currentValue / 100 == 0)
			{
				string digit = key.ToString().Replace("Alpha", "");
				_currentValue = _currentValue * 10 + int.Parse(digit);
				Debug.Log("現在の弾の値: " + _currentValue);
				ColorChange();
			}
		}

		// バックスペースで1桁削除
		if (Input.GetKeyDown(KeyCode.Backspace))
		{
			_currentValue /= 10;
			ColorChange();
		}

		_valueText.text = _currentValue.ToString();
	}

	void ColorChange()
	{
		if (_product.IsPrime(_currentValue))
		{
			_isShoot = true;
			_valueText.color = Color.blue;
		}
		else
		{
			_isShoot = false;
			_valueText.color = Color.red;
		}
	}

	public bool IsPrimeValue()
	{
		return _currentValue > 0 && _isShoot;
	}

	//プレイヤーが右クリックしたときに呼び出されるメソッド
	public int GetValue()
	{
		int value = _currentValue;
		_currentValue = 0;
		return value;
	}
}
