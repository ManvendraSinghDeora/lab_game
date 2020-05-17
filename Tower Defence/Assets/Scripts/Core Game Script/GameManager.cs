using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chest _ChestObject;
    string timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       timer =_ChestObject.CountDownTimer();
        Debug.Log(timer);
    }
}
