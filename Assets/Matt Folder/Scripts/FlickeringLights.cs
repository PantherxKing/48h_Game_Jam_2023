using UnityEngine;

public class FlickeringLights : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 0.1f;

    private Light flickeringLight;

    private void Start()
    {
        flickeringLight = GetComponent<Light>();
        InvokeRepeating("Flicker", 0f, flickerSpeed);
    }

    private void Flicker()
    {
        flickeringLight.intensity = Random.Range(minIntensity, maxIntensity);
    }
}