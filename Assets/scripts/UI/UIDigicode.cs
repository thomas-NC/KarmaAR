using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDigicode : MonoBehaviour
{
    public Text text;
    private string buttonValue;

    // Start is called before the first frame update
    void Start()
    {
        buttonValue = gameObject.GetComponentInChildren<Text>().text.ToString();
    }

    public void AddValue()
    {
        if (text.text.Length < 4)
        {
            text.text += buttonValue;
        }
    }

    public void ResetValue()
    {
        text.text = "";
    }

    public void ShowFicheIndice()
    {
        
    }
}
