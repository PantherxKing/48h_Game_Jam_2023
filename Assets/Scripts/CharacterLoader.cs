using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLoader : MonoBehaviour
{
    public Image Character;
    public Sprite M1;
    public Sprite M2;
    public Sprite M3;
    public Sprite M4;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("Selected Character");

        if(selectedCharacter == 0)
        {
            Character.sprite = M1;
        }
        if (selectedCharacter == 1)
        {
            Character.sprite = M2;
        }
        if (selectedCharacter == 2)
        {
            Character.sprite = M3;
        }
        if (selectedCharacter == 3)
        {
            Character.sprite = M4;
        }
    }
}
