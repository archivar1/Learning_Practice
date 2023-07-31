using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPs : MonoBehaviour
{
   private float timer, refresh, avgFrame;
   private string display = "{0} FPS";
   public Text text; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timelapse =Time.smoothDeltaTime;
        timer = timer <=0 ? refresh : timer -= timelapse;
        if (timer<=0)
         avgFrame = (int) (1f/timelapse);
         text.text = string.Format(display, avgFrame.ToString());
        
    }
}
