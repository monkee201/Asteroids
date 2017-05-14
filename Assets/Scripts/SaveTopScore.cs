using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTopScore : MonoBehaviour {

   public void StoreHighscore(int newHighscore)
    {
        int oldHighscore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", newHighscore);
    }

    public int GetTopScore()
    {
        return PlayerPrefs.GetInt("highscore");
    }
}
