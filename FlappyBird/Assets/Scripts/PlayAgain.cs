using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour {

    public void RestartScene()
    {
        ScoreManger.SCORE = 0;
        LifeManager.LIVES = 3;
        SceneManager.LoadScene(0);
    }


}
