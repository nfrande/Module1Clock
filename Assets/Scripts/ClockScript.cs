using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ClockScript : MonoBehaviour
{
    const float hoursToDegrees = 30f, minutesToDegrees = 6f, secondsToDegrees = 6f;
     [SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;
    void Awake () {
       
    }


    // Start is called before the first frame update
   
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      TimeSpan time = DateTime.Now.TimeOfDay;
           hoursPivot.localRotation = Quaternion.Euler(0f,hoursToDegrees * (float) time.TotalHours, 0f); 
            minutesPivot.localRotation =
			Quaternion.Euler(0f, minutesToDegrees * (float) time.TotalMinutes, 0f);
		secondsPivot.localRotation =
			Quaternion.Euler(0f, secondsToDegrees * (float) time.TotalSeconds, 0f);
    }
}
