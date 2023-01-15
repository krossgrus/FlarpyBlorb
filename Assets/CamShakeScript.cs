using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShakeScript : MonoBehaviour
{
    [SerializeField] private Animation cameraAnimator;
    [SerializeField] private string animationName = "CamAnimation";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
            cameraAnimator.Play(animationName);
        }
    }
}
