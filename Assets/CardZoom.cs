using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public bool zoomed = false;
    Vector3 originalPos;
    private void OnMouseOver()
    {
        if (!zoomed)
        {
            originalPos = transform.position;
            transform.position = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
            transform.localScale = transform.localScale * 2;
            zoomed = true;
        }
    }
    private void OnMouseExit()
    {
        if (zoomed)
        {
            transform.position = originalPos;
            transform.localScale = transform.localScale / 2;
            zoomed = false;
        }
    }
}
