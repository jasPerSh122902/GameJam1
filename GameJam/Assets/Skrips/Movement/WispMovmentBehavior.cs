using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispMovmentBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private  Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector2 _rotationDirection;
    [SerializeField]
    private float _rotationspeedY;
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private int _damage;
    public Vector3 MoveDirection
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }
    private Vector2 RotationDirection 
    {
        get { return _rotationDirection; }
        set { _rotationDirection = value; }
    }


    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //tells the rigidbody to move to a position
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
    }

    private void OnTriggerEnter(Collider other)
    {
            //increament the enemy count if the target was a goal
            EnemyBehaviour enemyHealth = other.GetComponent<EnemyBehaviour>();
            if (enemyHealth)
                enemyHealth.TakeDamage(_damage);
    }
}
