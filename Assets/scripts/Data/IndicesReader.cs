using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicesReader : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        IndicesCollection data = IndicesCollection.loadData("Assets/Data/Indices.xml");

        foreach (var item in data.indicesCollection)
        {
            if(item.id == 1)
            {
                Debug.Log(item.content);
            }
        }
    }

    
}
