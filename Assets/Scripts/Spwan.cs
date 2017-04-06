using UnityEngine;
using System.Collections;

public class Spwan : MonoBehaviour
{

    public GameObject[] Asteroids;

    // Use this for initialization
    void Start ()
    {
        GlobalValuesScript.NumberOfAsteroids = 0;

    }
	
	// Update is called once per frame
    void Update()
    {

        Vector3 pos = new Vector3(Random.Range(-60,60),Random.Range(-1,1),Random.Range(80,150));

        if (GlobalValuesScript.MaxNumberOfAsteroids > GlobalValuesScript.NumberOfAsteroids)
        {
            Instantiate(Asteroids[Random.Range(0, Asteroids.Length)],pos,Quaternion.identity);
            GlobalValuesScript.NumberOfAsteroids++;
        }
    }
}
