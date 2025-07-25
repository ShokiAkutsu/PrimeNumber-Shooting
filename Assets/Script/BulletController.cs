using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class BulletController : MonoBehaviour
{
    [SerializeField] float _speed = 3f;
	Rigidbody2D _rb;

	protected virtual void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
		_rb.gravityScale = 0; // 重力を無効にして自分で速度を管理
		_rb.velocity = new Vector2(0, _speed);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Block")
		{
			Destroy(this.gameObject);
		}
	}
}
