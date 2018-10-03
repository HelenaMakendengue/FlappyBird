using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

    public static int LIVES = 3;

    public Text text;
    private void Update()
    {
        text.text = "Lives: " + LIVES;
    }
}
