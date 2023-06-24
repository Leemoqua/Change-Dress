using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLeg : MonoBehaviour
{
    public GameObject ChooseLeg;
    public GameObject After;
    public List<GameObject> G = new List<GameObject>();


    public void whenButtonClicked()
    {
        int i = 0;
        if (ChooseLeg.activeInHierarchy == true)
            ChooseLeg.SetActive(false);
        else
            ChooseLeg.SetActive(true);

        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }

        After.GetComponent<BeforeList>().After[3] = (ChooseLeg);

    }
}
