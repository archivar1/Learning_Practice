using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class TImer1 : MonoBehaviour
{
    public float timeStart = 0;
    public Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    void Update()
    {
      
        timeStart +=Time.deltaTime;
        string minutes = ((int)timeStart/60).ToString();
        string seconds = (timeStart%60).ToString("f0");
        
        timerText.text = minutes+":"+seconds;
        if (Input.GetKeyDown(KeyCode.F))
        SceneManager.LoadScene("Menu");
    }
}