using UnityEngine.SceneManagement;
using UnityEngine;

public class GameWinManager : MonoBehaviour
{
    [SerializeField]
    Player play;

    private void Start()
    {
        play = GetComponent<Player>();
    }

    private void Update()
    {
        if (play.Health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
