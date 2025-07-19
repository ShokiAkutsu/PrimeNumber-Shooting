using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject _numberPrefab;
    [SerializeField] float _rengeX;
    [SerializeField] float _interval = 3f;
    float _time;

    // Start is called before the first frame update
    void Start()
    {
        _time = _interval;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if(_interval < _time)
        {
            _time = 0;

			float posX = Random.Range(-_rengeX, _rengeX);
			var prefab = Instantiate(_numberPrefab);
			prefab.transform.position = new Vector3(posX, transform.position.y, 0);
		}
	}
}
