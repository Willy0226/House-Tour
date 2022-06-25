using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathtrigger : MonoBehaviour
{
    [SerializeField] private Animator bathdoor = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bathdoor.Play("openbathdoor", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bathdoor.Play("closebathdoor", 0, 0.0f);
        }
    }
}
