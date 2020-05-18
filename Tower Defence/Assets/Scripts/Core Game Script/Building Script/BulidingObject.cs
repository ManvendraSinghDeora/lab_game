using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "New Buliding", menuName = "Scritable Object/Buliding")]
public class BulidingObject : ScriptableObject
{
    public int _CurrentStroageCapacity;
    public Sprite _CurrentArtWork;
    public int _CurrentLevel;

    public List<UpgradeObject> _Levels;
    public static void Main()
    {
        Debug.Log("Main Method");
    }

    private void Awake()
    {
        Debug.Log(_Levels.Count);
        //UpgradeSystem(false);
    }

    private void OnDisable()
    {
        _CurrentLevel = 1;
    }

    private void OnEnable()
    {
        UpgradeSystem(false); 
    }

    public void UpgradeSystem(bool isUpgrade)
    {
        if(isUpgrade)
            _CurrentLevel++;
        for (int i = 0; i < _Levels.Count; i++)
        {
            if (i == _CurrentLevel - 1 && _CurrentLevel<=_Levels.Count)
            {
                _CurrentStroageCapacity = _Levels[i]._TotalCapacity;
                _CurrentArtWork = _Levels[i]._ArtWork;
                Debug.Log("Loop Condition is working");
                return;
            }
        }
    }

    private void OnValidate()
    {
        if (_CurrentLevel <= 0)
            _CurrentLevel = 1;
    }
}

[System.Serializable]
public class UpgradeObject
{
   public int _TotalCapacity;
   public Sprite _ArtWork;
   public int _Range;
}