using UnityEngine;
using UnityEngine.SceneManagement;

public class HorsemenManager : MonoBehaviour
{
    // Take a list of horsemen, spawn one by one on previous's death until none are left, then change to win screen
    public GameObject[] horsemen;
    int currentHorsemen;

    private void Awake()
    {
        currentHorsemen = 0;
    }
    private void Update()
    {
        if (horsemen == null)
        {
            // load win screen
        }
        if (horsemen[currentHorsemen].GetComponent<HorsemenBase>().Health <= 0)
        {
            Destroy(horsemen[currentHorsemen]);
            if (currentHorsemen >= 4)
            { 
                //move to win scene
            }
            currentHorsemen += 1;
            Instantiate(horsemen[currentHorsemen]);
        }
    }


}
