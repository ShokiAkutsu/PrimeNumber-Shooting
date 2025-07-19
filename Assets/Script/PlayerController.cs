using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float _speed = 6f;
    Rigidbody2D _rb;
    //íeî≠éÀÇ…ïKóvÇ»å^
    [SerializeField] GameObject _bullet;
    [SerializeField] GameObject _primeBullet;
    [SerializeField] Transform _mazzle;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //ÉJÉEÉìÉgå∏è≠ÇÃíe
            Instantiate(_bullet, _mazzle);
        }
        if(Input.GetMouseButtonDown(1))
        {
			//ëfàˆêîï™âÇÃíe
			Instantiate(_primeBullet, _mazzle);
		}
    }

	private void FixedUpdate()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");
		_rb.velocity = new Vector2(horizontal * _speed, 0);
	}
}
