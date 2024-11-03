using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        
        System.DateTime currentTime = System.DateTime.Now;

        
        float hoursAngle = currentTime.Hour % 12 * 30f + currentTime.Minute * 0.5f;
        float minutesAngle = currentTime.Minute * 6f;   
        float secondsAngle = currentTime.Second * 6f;                               


        
        hourHand.localRotation = Quaternion.Euler( hoursAngle +94f, 0f, -90f);
        minuteHand.localRotation = Quaternion.Euler(-minutesAngle +94f, -180f, -270f);
        secondHand.localRotation = Quaternion.Euler(secondsAngle, 0f, -90f);
    }
}
