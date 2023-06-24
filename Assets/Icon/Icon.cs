using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public GameObject ChooseList;
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
        if (ChooseList.activeInHierarchy == true)
            ChooseList.SetActive(false);
        else
            ChooseList.SetActive(true);

        while (i < G.Count)
        {
            G[i].SetActive(false);
            i++;
        }
    }
}
