using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText1;
    [SerializeField] TextMeshProUGUI timerText2;

    float elapsedTime = 0f;
    private bool isTimerRunning = false;

    // Update is called once per frame
    void Update()
    {
        if(isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText1.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            timerText2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void ToggleTimer()
    {
        if(isTimerRunning)
        {
            StopTimer();
        }
        else
        {
            StartTimer();
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        Debug.Log("Timer started!");
    }

    public void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer stopped!");
    }
}