using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HorsemenManager : MonoBehaviour
{
    // Take a list of horsemen, spawn one by one on previous's death until none are left, then change to win screen
    public GameObject[] horsemen;
    int currentHorsemen;

    private void Awake()
    {
        DestroyHorsemen();
        currentHorsemen = 0;
        horsemen[currentHorsemen].SetActive(true);
    }
    private void Update()
    {
        if (horsemen == null)
        {
            // load win screen
        }
        if (CheckHealth(currentHorsemen))
        {
            
        }
    }
    bool CheckHealth(int index) 
    {
        return horsemen[index].GetComponent<HorsemenBase>().Health <= 0;
    }

    void NextHorseman() 
    {
        DestroyHorsemen();
        currentHorsemen += 1;
        if (currentHorsemen > 3)
        {
            DestroyHorsemen();
            //move to win scene
        }
        horsemen[currentHorsemen].SetActive(true);
    }
    void DestroyHorsemen() 
    {
        GameObject[] g = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i > g.Length;  i++)
        {
            g[i].SetActive(false);
        }
    }


}
