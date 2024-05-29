using System;
using TMPro;
using UnityEngine;

public class TimerComponent : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;

    void Start()
    {
        timerText.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = ConvertSecondsToTime(Time.time);
    }

    string ConvertSecondsToTime(float elapsedTime)
    {
        string minutes = ((int)(elapsedTime / 60)).ToString();
        string seconds = ((int)(elapsedTime % 60)).ToString();

        return string.Format("{0:mm:ss}", DateTime.Parse($"00:{minutes}:{seconds}"));
    }

}
