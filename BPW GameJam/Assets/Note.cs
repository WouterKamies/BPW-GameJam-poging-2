using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.AddForce(movement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
