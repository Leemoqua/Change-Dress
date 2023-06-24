using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBody: MonoBehaviour
{
    public GameObject ChooseBody;
    public GameObject After;
    public List<GameObject> G = new List<GameObject>();
  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenButtonClicked()
    {
        int i = 0;
        if (ChooseBody.activeInHierarchy == true)
            ChooseBody.SetActive(false);
        else
            ChooseBody.SetActive(true);
        
        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }
        
        After.GetComponent<BeforeList>().After[2] = (ChooseBody);
        
    }
}
