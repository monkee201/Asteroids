using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour
{

    private Transform _myTransform;
    private int minSpeed = 5;
    private int maxSpeed = 20;
    private Vector3 speed;
	// Use this for initialization
	void Start ()
	{
        
	    _myTransform = transform;

	    _myTransform.rotation = Random.rotation;
        speed = -Vector3.forward * Random.Range(minSpeed,maxSpeed);

	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(speed * Time.deltaTime);

	    if (_myTransform.position.z >60)
	    {
	       _myTransform.position = new Vector3(_myTransform.position.x,_myTransform.position.y,-60);
	    }
	    else if(_myTransform.position.z < -60)
	    {
            _myTransform.position = new Vector3(_myTransform.position.x, _myTransform.position.y, 60);
        }

        if (_myTransform.position.y > 60)
        {
            _myTransform.position = new Vector3(_myTransform.position.x, -60, _myTransform.position.z);
        }
        else if (_myTransform.position.y < -60)
        {
            _myTransform.position = new Vector3(_myTransform.position.x, 60, _myTransform.position.z);
        }

        if (_myTransform.position.x > 60)
        {
            _myTransform.position = new Vector3(-60, _myTransform.position.y, _myTransform.position.z);
        }
        else if (_myTransform.position.x < -60)
        {
            _myTransform.position = new Vector3(60,_myTransform.position.y, _myTransform.position.z);
        }

    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            GlobalValuesScript.NumberOfAsteroids--;
            GlobalValuesScript.Score += 10;
        }
    }
}
