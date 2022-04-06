using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MovementBehavriour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private Transform _damager;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _damage = 2;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public Transform Damager
    {
        get { return _damager; }
        set { _damager = value; }
    }

    // Update is called once per frame
    public  void Update()
    {
        Vector3 distance = _target.position - transform.position;

        Velocity = distance.normalized * Speed;
        base.Update();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //increament the enemy count if the target was a goal
            PlayerBaviour playerHealth = other.GetComponent<PlayerBaviour>();
            if (playerHealth)
                playerHealth.TakeDamage(_damage);
            //Destroyes this enemy
            Destroy(gameObject);
        }
        if (other.transform == _damager)
        {
            Destroy(gameObject);
        }
        
    }
    /// <summary>
    /// Destories the enemy if it was clicked with a mouse
    /// </summary>
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
