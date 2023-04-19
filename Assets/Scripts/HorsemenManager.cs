using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HorsemenManager : MonoBehaviour
{
    // Take a list of horsemen, spawn one by one on previous's death until none are left, then change to win screen
    public GameObject[] horsemen;
    public HorsemenBase horse;
    public bool horseDead = false;
    public int numKilled = 0;
    PlayerFeedback feedback;

    private void Awake()
    {
        feedback = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerFeedback>();
        Instantiate(horsemen[0], transform.position, Quaternion.identity);
    }
    private void Update()
    {
        if (CheckHealth())
        {
            horseDead = true;
        }
        if (horseDead && numKilled < 3)
        {
            numKilled += 1;
            Instantiate(horsemen[numKilled], transform);
            //horse = GameObject.FindGameObjectWithTag("Enemy").GetComponent<HorsemenBase>();
            //horse.animator.Play("Horsemen Spawn");
            horseDead = false;
        }
        else if ((horseDead && numKilled >= 3))
        {
            SceneManager.LoadScene("GameWin");
        }


    }

    private bool CheckHealth()
    {
        return horsemen[numKilled].gameObject == null || horsemen[numKilled].GetComponent<HorsemenBase>().Health <= 0;
    }
}
