using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

	string MenuScene = "MenuScene";


	void Update () {
	
		if(Input.anyKey)
		{
			SceneManager.LoadScene(MenuScene);
			Debug.Log ("Menu scene Loaded");
		}

	}
}
