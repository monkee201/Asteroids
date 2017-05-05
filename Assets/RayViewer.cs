using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewer : MonoBehaviour {

    public float weaponrangefloat = 500f;
    [SerializeField]
    private Camera fpscamera;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 lineOrigin = fpscamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        
	}
}
