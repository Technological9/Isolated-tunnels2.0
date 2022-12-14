using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jimmy_Donaldson : MonoBehaviour
{

    [SerializeField] private Animator AnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AnimationController.SetBool("Sussy Gussy", true);
        }
    }
    
}
