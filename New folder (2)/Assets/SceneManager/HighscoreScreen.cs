using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighscoreScreen : MonoBehaviour {

	string MenuScene = "MenuScene";


	public void BackToMenu()
	{
		SceneManager.LoadScene(MenuScene);
		Debug.Log ("Menu scene Loaded");
	}
}
