using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndicesReader : MonoBehaviour
{

    public Text indice;
    public Text index;
    public GameObject ficheIndice;
    private IndicesCollection data = new IndicesCollection();

    // Start is called before the first frame update
    void Start()
    {
        data = IndicesCollection.loadData("Assets/Data/Indices.xml");

        foreach (var item in data.indicesCollection)
        {
            Debug.Log("--id: " + item.id + "\n contenu = " + item.content + "--");
            
        }
    }

    public void ShowIndice()
    {
        indice.text = "";
        
        foreach (var item in data.indicesCollection)
        {
            if(index.text == item.id)
            {
                indice.text = item.content;
            }
        }
        ficheIndice.SetActive(true);
        index.text = "";
    }

    
}
