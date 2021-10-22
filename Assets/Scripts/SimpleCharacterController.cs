using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb = null;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [Range(-10, 10)]
    [SerializeField] private float acceleration = 0.0f;
    [SerializeField] private Vector3 directionVector = Vector3.zero;
    [SerializeField] private Transform directionIndicatorTransform = null;

    //public float moveSpeed = 10;
    ////Define the speed at which the object moves.

    //public float velocity;
    //public float jumpForce = 20f;

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    velocity = 0;
    //    float horizontalInput = Input.GetAxis("Horizontal");
    //    //Get the value of the Horizontal input axis.

    //    float verticalInput = Input.GetAxis("Vertical");
    //    //Get the value of the Vertical input axis.

    //    transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);
    //    //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.

    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        velocity = jumpForce;
    //    }

    //    transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    //}

    private void FixedUpdate()
    {
        this.velocity = rb.velocity;

        //float horizontalInput = Input.GetAxis("Horizontal");

        //float verticalInput = Input.GetAxis("Vertical");

        //this. directionVector = new Vector3(horizontalInput, 0, verticalInput);

        directionVector = this.directionIndicatorTransform.position - this.transform.position;

        this.velocity += directionVector.normalized * (acceleration * Time.deltaTime);

        this.rb.velocity = this.velocity;
    }
}
