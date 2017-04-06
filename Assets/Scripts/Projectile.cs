using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    private Transform _myTransform;
    public int speed = 10;

	// Use this for initialization
	void Start ()
	{

	    _myTransform = transform;

	}
	
	// Update is called once per frame
	void Update ()
	{
        
	        _myTransform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(_myTransform.position.z > 60)
            Destroy(gameObject);
	}
}
