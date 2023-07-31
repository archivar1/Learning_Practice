using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour
{
    public GameObject download;
    public float timeStart = 0;
    public Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    void Update()
    {
      
        timeStart +=Time.deltaTime;
        string hours = ((int)timeStart/3600).ToString();
        string minutes = (((int)timeStart/60)%60).ToString("f0");
        string seconds = (timeStart%60).ToString("f0");
        
        
        timerText.text =hours + ":" +  minutes+ ":" +seconds;
        if (Input.GetKeyDown(KeyCode.F))
        {
        download.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
