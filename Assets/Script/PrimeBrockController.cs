using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeBrockController : BlockController
{
    //�e�̃u���b�N�Ƃ̍��ʉ��������~��������
	//���̍\�z�F�f�������������u���b�N�͑f���������ł��Ȃ�
	//�f�������������u���b�N�������炩�_���[�W��^����΂܂��f���������ł���@���Ȃ���
	//�����f������������̂����J�M�ɂȂ�
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Bullet")
		{
			_numberController.Subtract();
		}
	}
}
