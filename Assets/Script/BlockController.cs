using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class BlockController : MonoBehaviour
{
	[SerializeField] float _fallSpeed = -1f; // �������ɓ��������߃}�C�i�X
	Rigidbody2D _rb;
	protected NumberController _numberController;

	void Start()
	{
		_rb = GetComponent<Rigidbody2D>();
		_rb.gravityScale = 0; // �d�͂𖳌��ɂ��Ď����ő��x���Ǘ�
		_rb.velocity = new Vector2(0, _fallSpeed);

		//�q���̃X�N���v�g���Ăяo��
		_numberController = GetComponentInChildren<NumberController>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.tag == "Bullet")
		{
			if (collision.gameObject.name.StartsWith("Prime"))
			{
				//�f���������̒e
				Debug.Log("Prime");
				
				_numberController.PrimeFactorization();
			}
			else
			{
				_numberController.Subtract();
			}
		}
	}
}
