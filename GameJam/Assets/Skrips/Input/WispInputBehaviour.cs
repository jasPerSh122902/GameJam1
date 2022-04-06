using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispInputBehaviour : MonoBehaviour

{ 
    private WispMovmentBehavior _wispMovement;
    private void Awake()
    {
        _wispMovement = GetComponent<WispMovmentBehavior>();
    }
    // Update
    void Update()
    {
        _wispMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }
}
