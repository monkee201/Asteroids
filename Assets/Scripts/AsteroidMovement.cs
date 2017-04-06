using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour
{

    private Transform _myTransform;
    private int minSpeed = 20;
    private int maxSpeed = 50;
    private Vector3 speed;
	// Use this for initialization
	void Start ()
	{

	    _myTransform = transform;
        speed = -Vector3.forward * Random.Range(minSpeed,maxSpeed);

	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(speed * Time.deltaTime);

	    if (_myTransform.position.z < -1)
	    {
	        Destroy(gameObject);
	        GlobalValuesScript.NumberOfAsteroids--;
	    }
	}

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            GlobalValuesScript.NumberOfAsteroids--;
        }
    }
}
