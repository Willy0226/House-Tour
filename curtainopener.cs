using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtainopener : MonoBehaviour
{
    [SerializeField] private Animator curtain = null;
    public GameObject sunlight;
    public GameObject Curtain;
    public GameObject mainlight;
    public GameObject spotlight;
    public GameObject mLight;
    public GameObject sLight;

    float max = 20f;
    float min = 0f;
    public float lightspeed = 2f;
    float lerpTime = 0f;

    bool inLivingRoom = false;

    void Start()
    { 
        sunlight.GetComponent<Light>().intensity = 0;
        sunlight.GetComponent<Light>().enabled = true;
        int lightStep = 100;
    }

    void Update()
    {
        if (inLivingRoom)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                lerpTime += (Time.deltaTime / lightspeed);
                curtain.Play("opencurtain", 0, 0.0f);
                sunlight.GetComponent<Light>().intensity = Mathf.Lerp(sunlight.GetComponent<Light>().intensity, max, lerpTime * 100);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                lerpTime += (Time.deltaTime / lightspeed);
                curtain.Play("closecurtain", 0, 0.0f);
                sunlight.GetComponent<Light>().intensity = Mathf.Lerp(sunlight.GetComponent<Light>().intensity, min, lerpTime * 100);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                mLight.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                mLight.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                sLight.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                sLight.SetActive(false);
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Curtain.SetActive(true);
            mainlight.SetActive(true);
            spotlight.SetActive(true);
            inLivingRoom = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Curtain.SetActive(false);
            mainlight.SetActive(false);
            spotlight.SetActive(false);
            inLivingRoom = false;
        }
    }
}
