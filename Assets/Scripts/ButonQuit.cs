using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonQuit : MonoBehaviour {

     public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
    }
}
