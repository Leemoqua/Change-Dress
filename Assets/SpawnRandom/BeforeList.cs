using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeforeList : MonoBehaviour
{
    public List<GameObject> Before = new List<GameObject>();
    public List<GameObject> After = new List<GameObject>();
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= 5; i++)
        {
            if (Before[0].GetComponent<Code>().Key == After[0].GetComponent<Code>().Key && Before[1].GetComponent<Code>().Key == After[1].GetComponent<Code>().Key && Before[2].GetComponent<Code>().Key == After[2].GetComponent<Code>().Key && Before[3].GetComponent<Code>().Key == After[3].GetComponent<Code>().Key && Before[4].GetComponent<Code>().Key == After[4].GetComponent<Code>().Key)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
