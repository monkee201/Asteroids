using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour {

    private Transform _myTransform;

    // Use this for initialization
    void Start () {
        _myTransform = transform;
    }
	
	// Update is called once per frame
	void Update () {
        CheckBounds();
    }

    private void CheckBounds()
    {
        if (_myTransform.position.x < 100 && _myTransform.position.x > -100
            && _myTransform.position.y < 100 && _myTransform.position.y > -100
            && _myTransform.position.z < 100 && _myTransform.position.z > -100)
        {
            GlobalValuesScript.InBounds = true;

        }
        else
            GlobalValuesScript.InBounds = false;


    }
}
