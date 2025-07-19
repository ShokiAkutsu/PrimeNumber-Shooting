using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberController : MonoBehaviour
{
	int _number;
	TextMesh _text;

	void Start()
	{
		_text = GetComponent<TextMesh>();
		//�f���̐ς��烉���_���Ő���
		//�f������������o�����萔��������ǂ����悤�H
		_number = 16;
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
}
