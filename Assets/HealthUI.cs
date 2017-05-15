using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

    [SerializeField]
    private GameObject go_Ship;
    public Text txt_Health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        txt_Health.text = go_Ship.GetComponent<Health>().GetCurrentHealth().ToString();
	}
}
