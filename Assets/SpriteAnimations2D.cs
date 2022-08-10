using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimations2D : MonoBehaviour
{
    public Animator animator = null;
    public string animationTrigger = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(this.animationTrigger);
        }
    }
}
