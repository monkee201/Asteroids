using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

        private void Start()
        {
            Invoke("Die",7f);
        }

        private void Die()
        {
            Destroy(gameObject);
        }
}
