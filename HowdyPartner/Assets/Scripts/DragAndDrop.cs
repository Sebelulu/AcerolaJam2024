using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDrop : MonoBehaviour
{

    PlayerInput input;
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    public void OnFirePrime(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        Debug.Log("Hello");
    }

    
}
