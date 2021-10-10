using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasterEgg : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    public bool alreadyTriggeredEG1;
    public bool alreadyTriggeredEG2;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        BlazeItEasterEgg();
        SixtyNineEasterEgg();
    }

    private void SixtyNineEasterEgg() //nice
    {
        if (score >= 69 && score < 71 && !alreadyTriggeredEG1)
        {
            print("Nice");
            alreadyTriggeredEG1 = true;
        }
    }

    private void BlazeItEasterEgg() //blaze it
    {
        if (score >= 420 && score < 422 && !alreadyTriggeredEG2)
        {
            print("420 Blaze it");
            alreadyTriggeredEG2 = true;
        }
    }
}
