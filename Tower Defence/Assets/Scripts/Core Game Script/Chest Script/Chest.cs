using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName ="New Chest",menuName = "Scritable Object/Chest")]
public class Chest : ScriptableObject
{
    public new string name;
    [Tooltip("Enter Time in Second")]
    public float _ChestTime;
    float _TimeLeft;
    public string _Discription;
    public Sprite _Artwork;

    private void OnEnable()
    {
        _TimeLeft = _ChestTime;
    }

    public string CountDownTimer()
    {
        if(_TimeLeft <= 0)
        {
            ChestOpen();
             
            return "00:00";
        }

        int minutes =(int)_TimeLeft / 60;
        int second = (int)_TimeLeft % 60;
        _TimeLeft -= Time.deltaTime;

        return minutes.ToString() + ":" + second.ToString();
        
    }


    public void ChestOpen()
    {
        Debug.Log("Open Chest Function");
    }

}


//[System.Serializable]
//class TimeConvertor
//{
//    public readonly string _Time;

//    public TimeConvertor(int time)
//    {
//        TimeSpan timeSpan = TimeSpan.FromSeconds(time);
//        this._Time = timeSpan.ToString("mm':'ss");
//    }

//}