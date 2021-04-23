using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynmicWaterLevel : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0,Mathf.Sin(Time.time) + 1,0); 
    }
}
