using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doortrigger : MonoBehaviour
{
    [SerializeField] private Animator closetdoor = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            closetdoor.Play("openclosetdoor", 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            closetdoor.Play("closeclosetdoor", 0, 0.0f);
        }
    }
}
