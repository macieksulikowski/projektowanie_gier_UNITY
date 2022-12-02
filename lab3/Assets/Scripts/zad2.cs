using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 target;
    private bool back= false;
    
    private void Update()
    {
        float step = speed * Time.deltaTime;
        if(!back)
        {
            target = new Vector3(10.0f, 0.0f, 0.0f);
        }
        if(back)
        {
            target = new Vector3(0.0f, 0.0f, 0.0f);
        }
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (Vector3.Distance(transform.position, target) < 1f)
        {
            if(back)
            {
                back = false;
            }
            else
            {
                back = true;
            }
        }
    }
}
