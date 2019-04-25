using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamController : MonoBehaviour
{
    public GameObject[] noteColliders;
    public KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Debug.Log("Pressed");
            CheckNote();
        }
    }

    public void CreateNote()
    {

    }

    public void CheckNote()
    {
        foreach (GameObject noteCollider in noteColliders)
        {
            noteCollider.
        }
    }
}
