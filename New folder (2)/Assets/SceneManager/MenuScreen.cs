using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScreen : MonoBehaviour {

	string AboutScene = "AboutScene";
	string HighscoreScene = "HighscoreScene";
	string GameScene = "GameScene";


	public void StartGame()
	{
		SceneManager.LoadScene(GameScene);
		Debug.Log ("Game scene Loaded");
	}

	public void About()
	{
		SceneManager.LoadScene(AboutScene);
		Debug.Log ("About scene Loaded");
	}

	public void Highscore()
	{
		SceneManager.LoadScene(HighscoreScene);
		Debug.Log ("Highscore scene Loaded");
	}

	public void Exit()
	{
		Application.Quit();
		Debug.Log("Aplication Quit");
	}
}
