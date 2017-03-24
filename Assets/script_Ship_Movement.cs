using UnityEngine;
using System.Collections;

public class script_Ship_Movement : MonoBehaviour {

    private Rigidbody rb_Ship;
    [SerializeField]
    private float f_thrust;

    // Use this for initialization
    void Start () {
        rb_Ship = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float f_Vertical = Input.GetAxis("Vertical");
        Debug.Log(f_Vertical);
            rb_Ship.AddForce(transform.forward * (f_thrust* f_Vertical));
        
        
	}
    
}
