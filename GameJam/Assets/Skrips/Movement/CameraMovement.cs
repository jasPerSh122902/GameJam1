using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MovementBehavriour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;

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


    //update
    // Update is called once per frame
    public override void Update()
    {
       Vector2 distance = _target.position - transform.position;

        Velocity = distance.normalized * Speed;

        base.Update();
    }
}
