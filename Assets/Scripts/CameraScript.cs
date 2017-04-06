using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{

    public Camera[] cam;
    private int currentCameraIndex;

	// Use this for initialization
	void Start ()
	{

	    currentCameraIndex = 0;

	    for (int i = 1; i < cam.Length; i++)
	    {
	        cam[i].gameObject.SetActive(false);
	    }

	    if (cam.Length > 0)
	    {
	        cam[0].gameObject.SetActive(true);
	    }
	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKeyDown(KeyCode.Z))
	    {
	        currentCameraIndex++;
	        if (currentCameraIndex < cam.Length)
	        {
	            cam[currentCameraIndex - 1].gameObject.SetActive(false);
	            cam[currentCameraIndex].gameObject.SetActive(true);
	        }
	        else
	        {
	            cam[currentCameraIndex-1].gameObject.SetActive(false);
	            currentCameraIndex = 0;
                cam[currentCameraIndex].gameObject.SetActive(true);
	        }
	    }

	}
}
