using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeBulletController : BulletController
{
    //���͂����f�����i�[����
    int _inputPrime;
	public int InputPrime { get; set; }

	protected override void Start()
	{
		base.Start();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
	}
}
