using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{
    public string displayString;
    public int score;

    public bool isColliding;

    public StreamController streamController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == streamController.lastNote)
       {
            isColliding = true;
       }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == streamController.lastNote)
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == streamController.lastNote)
        {
            isColliding = false;
        }
    }

}
