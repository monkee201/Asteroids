using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    private Text _score;

	// Use this for initialization
	void Start ()
	{
	    _score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _score.text = GlobalValuesScript.Score.ToString();
	}
}
