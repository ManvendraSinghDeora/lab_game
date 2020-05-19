using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    public Transform popuptransform;
    public GameObject troopspopup;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void trooppops()
    {
        Instantiate(troopspopup, popuptransform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
