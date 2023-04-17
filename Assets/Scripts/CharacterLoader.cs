using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    public GameObject Muskater1;
    public GameObject Muskater2;
    public GameObject Muskater3;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("Selected Character");

        if(selectedCharacter == 0)
        {
            Muskater1.SetActive(true);
        }
        if (selectedCharacter == 1)
        {
            Muskater2.SetActive(true);
        }
        if (selectedCharacter == 2)
        {
            Muskater3.SetActive(true);
        }
        //GameObject Prefab1 = characterPrefabs[selectedCharacter];
       // GameObject clone1 = Instantiate(Prefab1, Spawn.position, Quaternion.identity);
    }

  
}
