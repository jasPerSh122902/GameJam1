using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _goal;
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector2 _rotationDirection;
    [SerializeField]
    private float _rotationspeedY;
    [SerializeField]
    private float _rotationSpeedX;

    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }
    public Vector2 MouseDirection
    {
        get { return _rotationDirection; }
        set { _rotationDirection = value; }
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
       
    }
    //update
    private void FixedUpdate()
    {

        float cameraXRotation = Mathf.Clamp(transform.localRotation.eulerAngles.x + MouseDirection.y * _rotationspeedY * Time.deltaTime, -89, 89);

        Quaternion cameraRotaiton = Quaternion.Euler(cameraXRotation, 0, 0);


        //_camera.transform.Rotate(new Vector3(-cameraXRotation, 0, 0) * Time.deltaTime * _rotationSpeedX);
        Quaternion playerRotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + MouseDirection.x * _rotationspeedY * Time.deltaTime, 0);


        //tells the rigidbody to move to a position
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
        _rigidbody.transform.Rotate(transform.forward.x,transform.forward.y,0);
        // _rigidbody.MoveRotation(playerRotation);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (transform == _goal)
        {
            Destroy(_goal);

        }
    }
}
