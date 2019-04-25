using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScript : MonoBehaviour
{
    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;
    public AudioSource bongoSound;
    public float fireRate = 6f;
    private float nextTimeToFire = 0f;

    private void OnTriggerEnter(Collider other)
    {

        if (enter)
        {
            Debug.Log("entered");
            if (Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                bongoSound.Play();
            }

        }
    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.
    private float stayCount = 0.0f;
    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            if (stayCount > 0.25f)
            {
                Debug.Log("staying");
                stayCount = stayCount - 0.25f;
            }
            else
            {
                stayCount = stayCount + Time.deltaTime;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            Debug.Log("exit");
        }
    }
}