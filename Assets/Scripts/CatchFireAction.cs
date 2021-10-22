using UnityEngine;
using UnityEngine.InputSystem;

public class CatchFireAction : MonoBehaviour
{
    public InputActionReference fire;

    private void OnEnable()
    {
        fire.action.performed += Fire_performed;
    }

    private void Fire_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Fire pressed!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        fire.action.performed -= Fire_performed;
    }
}
