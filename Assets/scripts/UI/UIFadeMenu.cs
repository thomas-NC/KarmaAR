using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFadeMenu : MonoBehaviour
{
    private IEnumerator coroutine;
    // Start is called before the first frame update
    public void fadeOut(float time)
    {
        GetComponent<Image>().CrossFadeAlpha(0f, time, false);
        coroutine = waitAndDie(1f);
        StartCoroutine(coroutine);
        
        
    }

    private IEnumerator waitAndDie(float time)
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            gameObject.SetActive(false);
        }
    }

}
