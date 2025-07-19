using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class BlockController : MonoBehaviour
{
	[SerializeField] float _fallSpeed = -1f; // 下向きに動かすためマイナス
	Rigidbody2D _rb;
	NumberController _numberController;

	void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
		_rb.gravityScale = 0; // 重力を無効にして自分で速度を管理
		_rb.velocity = new Vector2(0, _fallSpeed);

		_numberController = GetComponentInChildren<NumberController>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Bullet")
		{
			if (collision.gameObject.name.StartsWith("Prime"))
			{
				//素因数分解の弾
				Debug.Log("Prime");
			}
			else
			{
				_numberController.Subtract();
			}
		}
	}
}
