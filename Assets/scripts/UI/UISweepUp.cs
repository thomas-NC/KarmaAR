using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISweepUp : MonoBehaviour
{
    public GameObject background;

    public float speed;
    public float initHeight;
    public float currentPos;

    private Vector2 ecran2;

    // Start is called before the first frame update
    void Start()
    {
        initHeight = background.GetComponent<RectTransform>().rect.height;
        ecran2 = new Vector2(0, initHeight);
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = background.GetComponent<RectTransform>().anchoredPosition.x;
        if (currentPos < initHeight)
        {
            background.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(background.GetComponent<RectTransform>().anchoredPosition, ecran2, Time.deltaTime * speed);
        }
    }
}
