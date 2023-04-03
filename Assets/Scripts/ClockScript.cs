using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ClockScript : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;
     [SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;
    [SerializeField] ClockSelector Clock_Type = ClockSelector.Smooth;
    enum ClockSelector
    {
        Smooth,
        Discrete,
    }
      
    
    void Awake () {
       
    }


    // Start is called before the first frame update
   
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       if (Clock_Type == ClockSelector.Discrete)
       {
       var time = DateTime.Now;
            hoursPivot.localRotation = 
            Quaternion.Euler(0f,hoursToDegrees * time.Hour, 0f); 
            minutesPivot.localRotation =
			Quaternion.Euler(0f, minutesToDegrees * time.Minute, 0f);
		    secondsPivot.localRotation =
            Quaternion.Euler(0f, secondsToDegrees * time.Second , 0f);
            secondsPivot.localRotation =
            Quaternion.Euler(0f, secondsToDegrees * time.Second, 0f);
       }
       if (Clock_Type == ClockSelector.Smooth)
       {
        TimeSpan time = DateTime.Now.TimeOfDay;
            hoursPivot.localRotation = Quaternion.Euler(0f,hoursToDegrees * (float) time.TotalHours, 0f); 
            minutesPivot.localRotation =
			Quaternion.Euler(0f, minutesToDegrees * (float) time.TotalMinutes, 0f);
		    secondsPivot.localRotation =
			Quaternion.Euler(0f, secondsToDegrees * (float) time.TotalSeconds, 0f);
       }
    }
}
