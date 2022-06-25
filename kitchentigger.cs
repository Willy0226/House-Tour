using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitchentigger : MonoBehaviour
{
    public GameObject kLight;
    public GameObject spotlight1;
    public GameObject spotlight2;
    public GameObject spotlight3;

    bool inKitchen = false;

    // Update is called once per frame
    void Update()
    {
        if(inKitchen)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                spotlight1.SetActive(true);
                spotlight2.SetActive(true);
                spotlight3.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                spotlight1.SetActive(false);
                spotlight2.SetActive(false);
                spotlight3.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kLight.SetActive(true);
            inKitchen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kLight.SetActive(false);
            inKitchen = false;
        }
    }
}
