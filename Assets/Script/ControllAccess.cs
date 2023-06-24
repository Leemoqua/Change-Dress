using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllAccess: MonoBehaviour
{
    public GameObject Choose;
    public GameObject After;
    public List<GameObject> G = new List<GameObject>();
  
    
    public void whenButtonClicked()
    {
        int i = 0;
        if (Choose.activeInHierarchy == true)
            Choose.SetActive(false);
        else
            Choose.SetActive(true);
        
        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }
        
        After.GetComponent<BeforeList>().After[0] = (Choose);
        
    }
}
