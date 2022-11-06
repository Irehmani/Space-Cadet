using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTracking : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int multipler;
    private float score;
    

    // Update is called once per frame
    void Update()
    {
        //alive for longer = more score
        score += Time.deltaTime * multipler;


        scoreText.text = Mathf.FloorToInt(score).ToString();
    }


}
