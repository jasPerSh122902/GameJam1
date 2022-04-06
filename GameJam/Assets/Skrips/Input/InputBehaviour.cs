using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InputBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _playerMovement;
    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {

        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("HorizontalArrow"), 0, 0).normalized;
        // _playerMovement.MouseDirection = new Vector2(Input.GetAxisRaw("MouseX"), Input.GetAxisRaw("MouseY")).normalized;
    }
}
