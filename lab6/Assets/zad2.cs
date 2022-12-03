using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float distance = 3f;
    public float doorSpeed = 1f;
    private float openPosition;
    private bool isOpen = false;

    private void Start()
    {
        openPosition = transform.position.x + distance;
    }
    private void Update()
    {
        if(isOpen)
        {
            Vector3 move = transform.right * doorSpeed * Time.deltaTime;
            if(transform.position.x <= openPosition)
            {
                transform.Translate(move);
            }
        }

    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
}