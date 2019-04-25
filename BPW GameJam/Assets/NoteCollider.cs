using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollider : MonoBehaviour
{
    public string displayString;
    public int score;

    public bool isColliding;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Note")
        {
        }
    }
}
