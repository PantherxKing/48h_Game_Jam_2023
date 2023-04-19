using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
/**
 * This script controls player movement and death 
 */ 
    public class player_behaviour : MonoBehaviour
    {
        float flyingPower = 0.2f;
        public GameObject player_bee;
        Rigidbody2D myRB;
        float move;

        // Kills player on entering anything tagged obstacle
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Obstacle"))
            {
                Destroy(this.gameObject);
                Scene sceneLoaded = SceneManager.GetActiveScene();
                SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
            }
            
        }
 
        void Start()
        {
            move = Input.GetAxisRaw("Vertical");
            if (!(Input.GetAxisRaw("Vertical") > 9))
            {
                myRB = player_bee.GetComponent<Rigidbody2D>();
            }
        }

        // Update is called once per frame
        void Update()
        {
            // calculates speed per frame
            move = Input.GetAxisRaw("Vertical");
            if (myRB.velocity.x < 5) // makes sure that the player has a max velocity
            {
                myRB.AddForce(move * flyingPower * new Vector3(0.1f, 1, 0), ForceMode2D.Impulse);
            }
            
        }

    }
