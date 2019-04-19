using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndicesReader : MonoBehaviour
{

    public Text indice;
    public Text index;
    public GameObject ficheIndice;
    private IndicesCollection ic = new IndicesCollection();

    public const string path = "Indices";

    // Start is called before the first frame update
    void Start()
    {

        IndicesCollection ic = IndicesCollection.loadData(path);

        foreach (Indice item in ic.indicesCollection)
        {
            //Debug.Log("--// id: " + item.id + "\n contenu = " + item.content + "//--");
            if(item.id == "99")
            {
                Debug.Log(item.content);
            }
        }
        /*data = IndicesCollection.loadData(Application.persistentDataPath + "/Indices.xml");
        Debug.Log(Application.persistentDataPath);

        foreach (var item in data.indicesCollection)
        {
            Debug.Log("--id: " + item.id + "\n contenu = " + item.content + "--");
            
        } */
    }

    public void ShowIndice()
    {
        IndicesCollection ic = IndicesCollection.loadData(path);
        indice.text = "";

        foreach (var item in ic.indicesCollection)
        {
            if(index.text == item.id)
            {
                indice.text = item.content;
                ficheIndice.SetActive(true);
            }
        }
        
        index.text = "";
    }

    
}
