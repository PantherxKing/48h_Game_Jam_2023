using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
/**
 * This script gets rid of each obstacle once it touches the gameobject this script is attached to
 *  - Bonus - It also adds points when it destroys each one 
 */
    public class cleaner_handler : MonoBehaviour
{
    int points = 0;
    Text pointsNum;

    // Destroys obstacles on collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            points += 1; // adds points
        }
        pointsNum.text = (points.ToString()); // Displays point in UI
    }
    private void Start()
    {
        pointsNum = GameObject.Find("UI_Canvas/pointsNum").GetComponent<Text>(); // Finds the text object we will be changing
    }
}

