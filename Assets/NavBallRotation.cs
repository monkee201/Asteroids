using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBallRotation : MonoBehaviour {
    [SerializeField]
    private Transform tf_Lock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.rotation = tf_Lock.rotation;
	}
}
