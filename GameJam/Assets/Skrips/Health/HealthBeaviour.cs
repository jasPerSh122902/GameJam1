using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBeaviour : MonoBehaviour
{
    [SerializeField]
    private int _health = 5;
    [SerializeField]
    private bool _isAlive;
    [SerializeField]
    private bool _distroyOnDeath;

    public int Health
    {
        get { return _health; }
    }
    public bool IsAlive
    {
        get { return _isAlive; }
    }

    public int TakeDamage(int damageAmount)
    {
        _health -= damageAmount;

        return damageAmount;
    }
    public virtual void OnDeath()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (_health < 0 && IsAlive)
            OnDeath();

        _isAlive = _health > 0;

        if (!IsAlive && _distroyOnDeath)
            Destroy(gameObject);
    }
}
