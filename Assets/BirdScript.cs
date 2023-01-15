using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logicScriptz;
    public bool birdIsAlive = true;
    public GameObject myCamera;
    public string animationName;

    // Proof that this is the way to reference other scripts in the game
    public PipeSpawnerScript nameofvariablethatreferencespipespawnerscript;

    // Start is called before the first frame update
    void Start()
    {
        // this creates a reference to another script so that we can call functions from that other script
        logicScriptz = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bird Collided");
        // Play camerashake animation
        Animation animator = myCamera.GetComponent<Animation>();
        animator.Play(animationName);
                
        myRigidbody.velocity += Vector2.left * 100;
        birdIsAlive = false;
        logicScriptz.gameOver();
          

    }

}

