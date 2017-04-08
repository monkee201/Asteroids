using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewer : MonoBehaviour {

    public float weaponrangefloat = 500f;
    private Camera fpscamera;


	// Use this for initialization
	void Start () {
        fpscamera = GetComponentInParent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 lineOrigin = fpscamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrigin, fpscamera.transform.forward * weaponrangefloat, Color.green);
	}
}
