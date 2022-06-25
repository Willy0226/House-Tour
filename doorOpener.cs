using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{

    [SerializeField] private bool isopening = false;

    [SerializeField] private Animator autodoor = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                autodoor.Play("opendoor", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            autodoor.Play("closedoor", 0, 0.0f);
        }
    }
}
