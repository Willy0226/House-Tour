using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedtrigger : MonoBehaviour
{
    public GameObject bLight;
    public GameObject sLight;
    public GameObject spotlight1;
    public GameObject spotlight2;
    public GameObject mlight;

    bool inBed = false;

    // Update is called once per frame
    void Update()
    {
        if (inBed)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                spotlight1.SetActive(true);
                spotlight2.SetActive(true);              
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                spotlight1.SetActive(false);
                spotlight2.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                mlight.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                mlight.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bLight.SetActive(true);
            sLight.SetActive(true);
            inBed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bLight.SetActive(false);
            sLight.SetActive(false);
            inBed = false;
        }
    }
}
