using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHair : MonoBehaviour
{
    public GameObject ChooseHair;
    public GameObject After;
    public List<GameObject> G = new List<GameObject>();


    public void whenButtonClicked()
    {
        int i = 0;
        if (ChooseHair.activeInHierarchy == true)
            ChooseHair.SetActive(false);
        else
            ChooseHair.SetActive(true);

        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }

        After.GetComponent<BeforeList>().After[1] = (ChooseHair);

    }
}
