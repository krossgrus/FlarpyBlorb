using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //Creates the slot in the inspector - needs to be filled in Unity
    public GameObject pipe;

    public float spawnRate = 2;
    
    private float timer = 0;

    public float heightOffset = 6;

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }


    // Start is called before the first frame update
    void Start()
    {
        
        //This is called to create the first pipe
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        //This adds +1 to the timer variable.
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnPipe();
            timer = 0;
        }

        
    }
}
