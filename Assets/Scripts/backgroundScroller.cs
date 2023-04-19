using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This script is in charge of the parallax effect in the background
 */ 
public class backgroundScroller : MonoBehaviour
{

    [SerializeField] private Vector2 parallaxEffectMultiplier;
    [SerializeField] private bool infiniteHorizontal; // allows me to set whether I want the obj to continue on the x-axis for eternity in Unity

    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private float textureUnitSizeX;

    private void Start()
    {
        cameraTransform = Camera.main.transform; // tracks the main camera (which also tracks the player as it is a child in my tree)
        lastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
    }

    private void LateUpdate()
    {
       
            Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
            transform.position += new Vector3(deltaMovement.x * - parallaxEffectMultiplier.x, deltaMovement.y * parallaxEffectMultiplier.y); // changes the position of the obj it is attached to
            lastCameraPosition = cameraTransform.position; // updates the value so delta movement is changing and not constant
            Sprite sprite = GetComponent<SpriteRenderer>().sprite;
            Texture2D texture = sprite.texture;

            if (infiniteHorizontal)
            {
                if (Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX)
                {
                    // moves the sprite IF the position of the camera in relation to the sprite's position is larger or equal to its width.
                    float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
                    transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y, transform.position.z);
                    
                }
            }

        
    }

}
