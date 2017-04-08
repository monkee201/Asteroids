using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarningScript : MonoBehaviour
{

    private Text warningText;

	// Use this for initialization
	void Start ()
	{

	    warningText = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update ()
	{

	    if (!GlobalValuesScript.InBounds)
	    {
            Debug.Log("puls");
	       StartCoroutine(Pulsate());
	    }
	    else
	        warningText.text = "";
	}


    IEnumerator Pulsate()
    {
        while (!GlobalValuesScript.InBounds)
        {
            warningText.text = "Out of range";
            yield return new WaitForSeconds(1);
            warningText.text = "";
            yield return new WaitForSeconds(1);
        }
    }
}
