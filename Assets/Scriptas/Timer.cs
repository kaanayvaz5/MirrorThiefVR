using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startTime;
    public Text timerText;
    
    void Start()
    {
        currentTime = startTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        int splitSec = (int)(currentTime * 100) % 100;
        int seconds = (int)(currentTime % 60);
        int minutes = (int)(currentTime / 60);

        string timerStr = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, splitSec);

        timerText.text = timerStr;
    }
}
