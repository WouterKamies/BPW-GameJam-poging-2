using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDestroyer : MonoBehaviour
{

    public GameController gameController;
    public int score;
    public string displayString;

    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Note")
        {
            Destroy(collision.gameObject);
            gameController.score += score;
            gameController.ShowText(displayString);
        }
    }
}
