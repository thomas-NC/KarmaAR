using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{
    private Canvas myObject;
    public GameObject TriggerObject;

    private int count = 0;


    void Start()
    {
        myObject = GetComponent<Canvas>();
    }


    void Update()
    {
        if (TriggerObject.transform.position.x > 24 && TriggerObject.transform.position.z < -22.5 && count <1)
        {
            count += 1;
            myObject.enabled = !myObject.enabled;
        }
    }
}
