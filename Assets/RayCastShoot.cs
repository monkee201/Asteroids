using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour {

    public float f_fire_Rate = 0.25f;
    public float f_weapon_Range = 50f;
    public float f_hit_Force = 500f;
    public Transform tf_gun_End;
    [SerializeField]
    private Camera c_ship_Camera;
    private WaitForSeconds wfs_shot_Duration = new WaitForSeconds(0.07f);
    private LineRenderer lr_laser_Line;
    private float f_next_Fire;

	void Start () {
        lr_laser_Line = GetComponent<LineRenderer>();
	}
	
	void Update () {
		if(Input.GetButton ("Fire2") && Time.time > f_next_Fire)
        {
            f_next_Fire = Time.time + f_fire_Rate;

            StartCoroutine(ShotEffect());
            Vector3 tmp_v3_ray_Origin = c_ship_Camera.ViewportToWorldPoint(new Vector3 (0.5f , 0.5f, 0f));
            RaycastHit tmp_rh_hit;

            lr_laser_Line.SetPosition(0, tf_gun_End.position);

            if(Physics.Raycast(tmp_v3_ray_Origin, c_ship_Camera.transform.forward, out tmp_rh_hit, f_weapon_Range))
            {
                lr_laser_Line.SetPosition(1, tmp_rh_hit.point);
                AsteroidMovement scpt_AM = tmp_rh_hit.collider.GetComponent<AsteroidMovement>();
                if (scpt_AM != null)
                {
                    scpt_AM.Die();
                }

            }
            else
            {
                lr_laser_Line.SetPosition(1, tmp_v3_ray_Origin + (c_ship_Camera.transform.forward * f_weapon_Range));
            }
            
        }
	}

    private IEnumerator ShotEffect ()
    {
        lr_laser_Line.enabled = true;
        yield return wfs_shot_Duration;
        lr_laser_Line.enabled = false;

    }
}
