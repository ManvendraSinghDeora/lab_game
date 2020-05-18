using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Chest _ChestObject;
    public BulidingObject _BulidingObject;
    string timer;
    public bool upgrade;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (upgrade)
        {
            _BulidingObject.UpgradeSystem(true);
            upgrade = false;
        }
        Debug.Log(_BulidingObject._CurrentStroageCapacity);
        //timer = _ChestObject.CountDownTimer();
        //Debug.Log(timer);

    }
}
