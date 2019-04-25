using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NoteDestroyer : MonoBehaviour
{

    public GameController gameController;
    public StreamController streamController;
    public int score;
    public string displayString;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
            gameController.score += score;
            gameController.ShowText(displayString);
        streamController.noteArray.Remove(streamController.lastNote);
       if (streamController.noteArray[0] != null)
        {
            streamController.lastNote = streamController.noteArray[0];
       }

    }
}
