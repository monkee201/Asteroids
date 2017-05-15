using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour
{
    public GameObject[] Asteroids;

    private Transform _myTransform;
    private int minSpeed = 5;
    private int maxSpeed = 20;
    private Vector3 speed;
    private float size;

    // Use this for initialization
    void Start ()
	{
        
	    _myTransform = transform;

	    _myTransform.rotation = Random.rotation;
	    size = Random.Range(1, 5);
        _myTransform.localScale = new Vector3(size,size,size);
        speed = -Vector3.forward * Random.Range(minSpeed,maxSpeed);

	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(speed * Time.deltaTime);

	    if (_myTransform.position.z >GlobalValuesScript.PlayArea)
	    {
	       _myTransform.position = new Vector3(_myTransform.position.x,_myTransform.position.y,-GlobalValuesScript.PlayArea);
	    }
	    else if(_myTransform.position.z < -GlobalValuesScript.PlayArea)
	    {
            _myTransform.position = new Vector3(_myTransform.position.x, _myTransform.position.y, GlobalValuesScript.PlayArea);
        }

        if (_myTransform.position.y > GlobalValuesScript.PlayArea)
        {
            _myTransform.position = new Vector3(_myTransform.position.x, -GlobalValuesScript.PlayArea, _myTransform.position.z);
        }
        else if (_myTransform.position.y < -GlobalValuesScript.PlayArea)
        {
            _myTransform.position = new Vector3(_myTransform.position.x, GlobalValuesScript.PlayArea, _myTransform.position.z);
        }

        if (_myTransform.position.x > GlobalValuesScript.PlayArea)
        {
            _myTransform.position = new Vector3(-GlobalValuesScript.PlayArea, _myTransform.position.y, _myTransform.position.z);
        }
        else if (_myTransform.position.x < -GlobalValuesScript.PlayArea)
        {
            _myTransform.position = new Vector3(GlobalValuesScript.PlayArea, _myTransform.position.y, _myTransform.position.z);
        }

    }

   /* public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Projectile"))
        {
            GlobalValuesScript.Score += 10;
            Instantiate(Asteroids[Random.Range(0, Asteroids.Length)], _myTransform.position, Quaternion.identity);
            Instantiate(Asteroids[Random.Range(0, Asteroids.Length)], _myTransform.position, Quaternion.identity);
            Destroy(gameObject);
            GlobalValuesScript.NumberOfAsteroids++;
           
        }
    }*/

   
    public void Die()
    {
        GlobalValuesScript.Score += 10;
        Instantiate(Asteroids[Random.Range(0, Asteroids.Length)], _myTransform.position, Quaternion.identity);
        Instantiate(Asteroids[Random.Range(0, Asteroids.Length)], _myTransform.position, Quaternion.identity);
        Destroy(gameObject);
        GlobalValuesScript.NumberOfAsteroids++;
    }
}
