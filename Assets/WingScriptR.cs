using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingScriptR : MonoBehaviour
{

    Rigidbody2D BirdRB;
    private Animator wingAnimator;
    private string currentState;
    //private string newState;

    const string WingFlapAnimationR = "WingFlapAnimationR";
    const string WingChillAnimationR = "WingChillAnimationR";

    // Start is called before the first frame update
    void Start()
    {
        BirdRB = GameObject.FindGameObjectWithTag("Bird").GetComponent<Rigidbody2D>();
        wingAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckBirdRB();
        Debug.Log("Bird y velocity = " + BirdRB.velocity.y);
    }

    private void CheckBirdRB()
    {
        if (BirdRB.velocity.y <5)
        {
            //Play chill animation
            ChangeAnimationTo(WingChillAnimationR);
        }
        else
        {
            //Play flap animation
            ChangeAnimationTo(WingFlapAnimationR);
        }
    }

    private void ChangeAnimationTo(string newState)
    {

        if (currentState == newState) return;
        
        wingAnimator.Play(newState);
        currentState = newState;
        
        
    }
}
