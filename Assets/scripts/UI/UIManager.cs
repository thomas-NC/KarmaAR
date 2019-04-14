using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Update is called once per frame
    public void sweepRight()
    {
        GetComponent<UISweepBack>().enabled = false;
        GetComponent<UISweepRight>().enabled = true;
    }

    public void sweepBack()
    {
        GetComponent<UISweepRight>().enabled = false;
        GetComponent<UISweepLeft>().enabled = false;
        GetComponent<UISweepUp>().enabled = false;
        GetComponent<UISweepBack>().enabled = true;     
    }

    public void sweepUp()
    {
        GetComponent<UISweepBack>().enabled = false;
        GetComponent<UISweepUp>().enabled = true;
    }

    public void sweepLeft()
    {
        GetComponent<UISweepBack>().enabled = false;
        GetComponent<UISweepLeft>().enabled = true;
    }
}
