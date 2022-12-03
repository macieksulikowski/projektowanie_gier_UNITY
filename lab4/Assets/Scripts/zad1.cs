using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random=UnityEngine.Random;

public class zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int Objects = 10;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    Collider Collider;
    Vector3 Size;

    void Start()
    {
         // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        Collider = GetComponent<Collider>();
        Size = Collider.bounds.size;
        int min_x= (int)(transform.position.x - (Size.x/2));
        int max_x= (int)(transform.position.x + (Size.x/2));
        int min_z= (int)(transform.position.z - (Size.z/2));
        int max_z= (int)(transform.position.z + (Size.z/2));

        for(int i=0; i<Objects; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(min_x,max_x),5, Random.Range(min_z, max_z));
            this.positions.Add(randomSpawnPosition);
        }
        foreach(Vector3 elem in positions){
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach(Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
