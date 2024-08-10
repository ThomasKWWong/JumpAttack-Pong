using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{

    public TextMeshProUGUI scoreOne;
    public TextMeshProUGUI scoreTwo;

    // Start is called before the first frame update
    void Start()
    {
        scoreOne.text = "0";
        scoreTwo.text = "0";
    }

    public void UptickScoreOne(){
        scoreOne.text = (int.Parse(scoreOne.text)+1).ToString();
    }

    public void UptickScoreTwo(){
        scoreTwo.text = (int.Parse(scoreTwo.text)+1).ToString();
    }
}
