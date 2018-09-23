using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopScore : MonoBehaviour {

    public static int HIGHSCORE = 0;

    public Text text;

    void Update () {
        if(ScoreManger.SCORE > HIGHSCORE) {
            HIGHSCORE = ScoreManger.SCORE;
        }
        text.text = "Top Score: " + HIGHSCORE;
    }
}
