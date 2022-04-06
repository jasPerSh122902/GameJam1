using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavriour : MonoBehaviour
{
    [SerializeField]
    private Vector3 _velocity;
    /// <summary>
    /// speed and direction of the game object
    /// </summary>
    public Vector3 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }
    // Update is called once per frame
    public virtual void Update()
    {
        transform.position += Velocity * Time.deltaTime;
    }
}
