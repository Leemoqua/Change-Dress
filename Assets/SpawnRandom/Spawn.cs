using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Main;
    public GameObject Before;
    public List<GameObject> Accesory = new List<GameObject>();
    public List<GameObject> Hair = new List<GameObject>();
    public List<GameObject> Body = new List<GameObject>();
    public List<GameObject> Leg = new List<GameObject>();
    public List<GameObject> Foot = new List<GameObject>();
    


    // Start is called before the first frame update

    void Start()
    {
        int i = Random.Range(0, Accesory.Count);
        Accesory[i].SetActive(true);

        int j = Random.Range(0, Hair.Count);
        Hair[j].SetActive(true);

        int k = Random.Range(0, Body.Count);
        Body[k].SetActive(true);

        int q = Random.Range(0, Leg.Count);
        Leg[q].SetActive(true);

        int h = Random.Range(0, Foot.Count);
        Foot[h].SetActive(true);

        //GameObject g = Instantiate(Prefabs[i]);
        Before.GetComponent<BeforeList>().Before.Add(Accesory[i]);
        Before.GetComponent<BeforeList>().Before.Add(Hair[j]);
        Before.GetComponent<BeforeList>().Before.Add(Body[k]);
        Before.GetComponent<BeforeList>().Before.Add(Leg[q]);
        Before.GetComponent<BeforeList>().Before.Add(Foot[h]);
        
        Invoke("Open", 5.0f);

    }
    void Open()
    {
        Main.SetActive(true);
    }
    // Update is called once per frame

}
