using UnityEngine;
using System.Collections;

public class script_Ship_Movement : MonoBehaviour
{

    private Transform _myTransform;
    public int sideSpeed = 10;

    public GameObject projectile;

    // Use this for initialization
    void Start ()
    {
        _myTransform = transform;

        //Spawn point
        _myTransform.position = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {
    
        // Lateral movement
        _myTransform.Translate(Vector3.right * sideSpeed *Input.GetAxis("Horizontal")* Time.deltaTime);

        Vector3 position = new Vector3(_myTransform.position.x, _myTransform.position.y - 0.4f , _myTransform.position.z + 1.5f);


	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	        Instantiate(projectile,position,Quaternion.identity);
	    }

        }
    
}
