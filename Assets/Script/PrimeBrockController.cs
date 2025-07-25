using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeBrockController : BlockController
{
    //親のブロックとの差別化制限が欲しいため
	//今の構想：素因数分解したブロックは素因数分解できない
	//素因数分解したブロック→いくらかダメージを与えればまた素因数分解できる　をなくす
	//→いつ素因数分解するのかがカギになる
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Bullet")
		{
			_numberController.Subtract();
		}
	}
}
