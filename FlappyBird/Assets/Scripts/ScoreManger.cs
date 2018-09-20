using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManger : MonoBehaviour {

    public static int SCORE = 0;

    public Text text;
    private void Update()
    {
        text.text = "Score: " + SCORE;
    }
}
