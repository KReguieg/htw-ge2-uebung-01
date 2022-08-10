using System;
using System.Collections;
using UnityEngine;

public class FadeAnimation : MonoBehaviour
{
    [SerializeField] private float alpha = 1.1f;
    [SerializeField] private bool fadeOverTime = false;

    [SerializeField] private float walkingSpeed = 0.0f;
    
    private Renderer renderer;
    private Animator animator;

    private Coroutine fadeRoutine;

    private WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    // Start is called before the first frame update
    void Start()
    {
        this.renderer = this.GetComponent<Renderer>();


        this.animator = this.GetComponent<Animator>();

        //this.animator.SetBool("idleing", false);
        //this.animator.SetFloat("walkingSpeed", this.walkingSpeed);
        //this.animator.SetInteger("number", 3);
        //this.animator.SetTrigger("triggered");

        //StartCoroutine(this.CustomCoroutine());

        //StartCoroutine("FadeCoroutine");
        //StartCoroutine(this.FadeCoroutine());
        //this.fadeRoutine = StartCoroutine(this.FadeCoroutine());

        //StopCoroutine("FadeCoroutine");
        //StopCoroutine(this.fadeRoutine);
        //StopAllCoroutines();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //StopCoroutine(this.fadeRoutine);
            // this.Fade();
            //this.fadeOverTime = true;
            //StartCoroutine(this.CustomCoroutine());
            this.animator.SetTrigger("walkingTriggered");
        }

        //if (this.alpha > 0 && fadeOverTime)
        //{
        //    Color c = this.renderer.sharedMaterial.color;
        //    c.a = this.alpha;

        //    this.alpha -= 0.01f;
        //    renderer.sharedMaterial.color = c;
        //}
    }

    private IEnumerator CustomCoroutine()
    {
        yield return new WaitForRightMouseDown();
        Debug.Log("Waited for right mouse down!");
    }

    private IEnumerator Coroutine()
    {
        yield return new WaitForEndOfFrame();
    }

    private IEnumerator FadeCoroutine()
    {
        for (float f = 1f; f >= 0; f -= 0.001f)
        {
            Color c = renderer.sharedMaterial.color;
            c.a = f;
            renderer.sharedMaterial.color = c;
            yield return waitForEndOfFrame;
        }
    }

    private void Fade()
    {
        Color c = renderer.sharedMaterial.color;
        for (float i = 1f; i >= 0; i -= 0.1f)
        {
            c.a = i;
            this.renderer.sharedMaterial.color = c;
        }
    }
}
