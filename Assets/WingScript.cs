using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingScript : MonoBehaviour
{

    Rigidbody2D BirdRB;
    private Animator wingAnimator;
    private string currentState;
    //private string newState;

    const string WingFlapAnimation = "WingFlapAnimation";
    const string WingChillAnimation = "WingChillAnimation";

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
            ChangeAnimationTo(WingChillAnimation);
        }
        else
        {
            //Play flap animation
            ChangeAnimationTo(WingFlapAnimation);
        }
    }

    private void ChangeAnimationTo(string newState)
    {

        if (currentState == newState) return;
        
        wingAnimator.Play(newState);
        currentState = newState;
        
        
    }
}
