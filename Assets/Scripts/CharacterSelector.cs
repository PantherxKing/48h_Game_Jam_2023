using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    public TextMeshProUGUI characterName;
    public Image portrait;
    public string UICharacterName;
    public GameObject PortaitGo;
    public GameObject playButton;


    public void Awake()
    {
        PortaitGo.SetActive(false);
        playButton.SetActive(false);
    }

    public void UpdateUI(CharacterSO CharacterSciptableObject)
    {
        PortaitGo.SetActive(true);
        portrait.sprite = CharacterSciptableObject.Portrait;
        UICharacterName = CharacterSciptableObject.Name;
        characterName.text = UICharacterName;
        playButton.SetActive(true);
        PlayerPrefs.SetInt("Selected Character", CharacterSciptableObject.IDNumber);
    }
   
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
