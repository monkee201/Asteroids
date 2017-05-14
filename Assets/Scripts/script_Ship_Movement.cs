using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class script_Ship_Movement : MonoBehaviour {

    
    private Rigidbody rb_Ship;
    [SerializeField]
    private Text txt_Speed;
    [SerializeField]
    private float f_thrust;
    [SerializeField]
    private float f_power = 0;
    private float f_roll = 0;
    private float f_pitch = 0;
    private float f_speed;

    // Use this for initialization
    void Start () {
        rb_Ship = GetComponent<Rigidbody>();
        
    }
	
	// Update is called once per frame
	void Update () {

        Thrust();
        rotation();
        f_speed = rb_Ship.velocity.magnitude;
        txt_Speed.text = f_speed.ToString("0.00") +" m/s";
    }
    
    void rotation()
    {
        f_roll = Input.GetAxis("Horizontal");
        f_pitch = Input.GetAxis("Vertical");

        rb_Ship.AddTorque(rb_Ship.transform.forward * f_pitch * 5);
        rb_Ship.AddTorque(rb_Ship.transform.right * f_roll * 5);
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
