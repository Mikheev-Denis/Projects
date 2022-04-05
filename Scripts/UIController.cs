using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider timer;
    public Text timerText;
    public float gameTime;
    public BackPack bp;
    public bool stopTimer;
    public float lvlTime;
    void Start()
    {
        stopTimer = false;
        timer.maxValue = gameTime;
        timer.value = gameTime;
        bp.homeScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float time = gameTime - Time.time;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);
        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if(time <= 0)
        {
            stopTimer = true;
            bp.AddtoBP();
            bp.homeScreen.SetActive(true);

        }
        if(stopTimer == false)
        {
            timerText.text = textTime;
            timer.value = time;
            stopTimer = false;

            
        }

        
    }
}
