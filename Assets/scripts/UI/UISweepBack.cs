using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISweepBack : MonoBehaviour
{
    public GameObject background;

    public float speed;
    public float initWidth;
    public float currentPos;

    private Vector2 ecran2;

    // Start is called before the first frame update
    void Start()
    {
        initWidth = background.GetComponent<RectTransform>().rect.width;
        ecran2 = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = background.GetComponent<RectTransform>().anchoredPosition.x;
        if (currentPos < initWidth)
        {
            background.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(background.GetComponent<RectTransform>().anchoredPosition, ecran2, Time.deltaTime * speed);
        }
    }
}
