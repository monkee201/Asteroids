using UnityEngine;
using System.Collections;

public class script_Ship_Movement : MonoBehaviour {

    private Rigidbody rb_Ship;
    [SerializeField]
    private float f_thrust;
    private float f_power = 0;
    private float f_roll = 0;
    private float f_pitch = 0;

    // Use this for initialization
    void Start () {
        rb_Ship = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        Thrust();
        rotation();




    }
    
    void rotation()
    {
        f_roll = Input.GetAxis("Horizontal");
        f_pitch = Input.GetAxis("Vertical");
        rb_Ship.transform.Rotate(Vector3.forward * f_pitch);
        rb_Ship.transform.Rotate(Vector3.right * f_roll);
    }
    void Thrust()
    {
        if (Input.GetButton("Fire1"))
        {
            f_power = -1;
        }
        else
        {
            f_power = 0;
        }

        rb_Ship.AddForce(transform.right * (f_thrust * f_power));
    }


}
