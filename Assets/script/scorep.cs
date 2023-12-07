using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scorep : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public static int scorecount;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scorecount = score;

        scoretext.text = "score:" + Mathf.Round(scorecount);
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "score:" + Mathf.Round(scorecount);
    }

}