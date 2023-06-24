using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFooot : MonoBehaviour
{
    public GameObject ChooseFoot;
    public GameObject After;
    public List<GameObject> G = new List<GameObject>();


    public void whenButtonClicked()
    {
        int i = 0;
        if (ChooseFoot.activeInHierarchy == true)
            ChooseFoot.SetActive(false);
        else
            ChooseFoot.SetActive(true);

        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }

        After.GetComponent<BeforeList>().After[4] = (ChooseFoot);

    }
}
