using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StreamController : MonoBehaviour
{
    public NoteCollider[] noteColliders;
    public KeyCode keyCode;
    public GameController gameController;
    public Transform noteSpawnPoint;
    public GameObject note;
    public int delay;
    private int timer;
    public GameObject lastNote;
    public List<GameObject> noteArray;

    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;

        if (timer <= 0)
        {
            CreateNote();
            timer = delay;
        }

        if (Input.GetKeyDown(keyCode))
        {
            //Debug.Log("Check note");
            CheckNote();
        }

        /*if (Input.GetKeyDown(KeyCode.A))
        {
            //Debug.Log("New note");
            CreateNote();
        }*/
    }

    public void CreateNote()
    {
        GameObject newNote = Instantiate(note, noteSpawnPoint);
        noteArray.Add(newNote);
        lastNote = noteArray[0];

    }

    public void CheckNote()
    {


        foreach (NoteCollider noteCollider in noteColliders)
        {
            if (noteArray[0] != null)
            {
                lastNote = noteArray[0];

            }
            if (noteCollider.isColliding)
            {
                gameController.ShowText(noteCollider.displayString);
                gameController.score += noteCollider.score;
                Destroy(lastNote);
                noteArray.Remove(lastNote);
                //noteArray.
                if (noteArray[0] != null)
                {
                    lastNote = noteArray[0];
                }
                noteCollider.isColliding = false;
                break;
            }
        }

        foreach (NoteCollider noteCollider in noteColliders)
        {
            noteCollider.isColliding = false;
        }
    }
}