using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTriggerScript : MonoBehaviour
{
    // Create the "logic" slot on the script component in the inspector
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        // this creates a reference to another script so that we can call functions from that other script
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.attachedRigidbody.velocity.x);

        if (collision.gameObject.layer == 3 && collision.attachedRigidbody.velocity.x == 0)
        {
            logic.addScore(10);
        }
        
    }

}
