using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HorsemenManager : MonoBehaviour
{
    // Take a list of horsemen, spawn one by one on previous's death until none are left, then change to win screen
    public GameObject horsemen;
    public bool horseDead = false;
    int numKilled = 0;

    private void Awake()
    {
        Instantiate(horsemen, transform.position, Quaternion.identity);
    }
    private void Update()
    {
        if (CheckHealth())
        {
            horseDead = true;
        }
        if (horseDead && numKilled < 3)
        {
            print("test");
            Instantiate(horsemen, transform);
            numKilled += 1;
            horseDead = false;
        }
        else if ((horseDead && numKilled >= 3))
        {
            SceneManager.LoadScene("GameWin");
        }


    }

    private bool CheckHealth()
    {
        return horsemen.gameObject == null || horsemen.GetComponent<HorsemenBase>().Health <= 0;
    }
}
