using UnityEngine;


public class CollisionExample : MonoBehaviour
{
    [SerializeField] MeshRenderer objectMesh = null;
    [SerializeField] Rigidbody rb = null;
    [SerializeField] float upForceMultiplier = 0.0f;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter collision with= " + collision.gameObject.name);
        this.objectMesh.material.color = Color.blue;
        this.rb.AddForce(Vector3.up * this.upForceMultiplier, ForceMode.Impulse);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay in collision with= " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit collision with= " + collision.gameObject.name);
        this.objectMesh.material.color = Color.red;
    }
}
