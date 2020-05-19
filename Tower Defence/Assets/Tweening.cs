using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweening : MonoBehaviour
{
    public LeanTweenType outType;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1.5f, 1f, 1f), 0.3f).setEase(outType).setDestroyOnComplete(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
