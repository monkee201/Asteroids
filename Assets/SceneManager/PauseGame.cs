using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	public Transform canvas;
	public Transform PauseMenu;
	public Transform VolumeMenu;
	public Transform VideoMenu;
	public Transform ControlsMenu;

	void Start(){

	}

	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Pause ();
			Debug.Log ("Pause Menu Opens");
		}
	}

	public void Pause()
	{
		if (canvas.gameObject.activeInHierarchy == false) 
		{
			if (PauseMenu.gameObject.activeInHierarchy == false) 
			{
				PauseMenu.gameObject.SetActive (true);
				VolumeMenu.gameObject.SetActive (false);
				VideoMenu.gameObject.SetActive (false);
				ControlsMenu.gameObject.SetActive (false);
			}

			canvas.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
		else 
		{
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
		}
	}

	public void Volume(bool open)
	{
		if (open)
		{
			VolumeMenu.gameObject.SetActive (true);
			PauseMenu.gameObject.SetActive (false);
		}
		if (!open) 
		{
			VolumeMenu.gameObject.SetActive (false);
			PauseMenu.gameObject.SetActive (true);
		}
	}


	public void Video(bool open)
	{
		if (open)
		{
			VideoMenu.gameObject.SetActive (true);
			PauseMenu.gameObject.SetActive (false);
		}
		if (!open) 
		{
			VideoMenu.gameObject.SetActive (false);
			PauseMenu.gameObject.SetActive (true);
		}
	}


	public void Controls(bool open)
	{
		if (open)
		{
			ControlsMenu.gameObject.SetActive (true);
			PauseMenu.gameObject.SetActive (false);
		}
		if (!open) 
		{
			ControlsMenu.gameObject.SetActive (false);
			PauseMenu.gameObject.SetActive (true);
		}
	}



}
