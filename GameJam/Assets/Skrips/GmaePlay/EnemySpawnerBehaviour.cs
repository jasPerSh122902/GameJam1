using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyMovementBehaviour _enemy;
    [SerializeField]
    private Transform _enemyTarget;
    [SerializeField]
    private Transform _enemyDamger;
    [SerializeField]
    private float _spawnTimer = 5;
    private float _timer = 0.0f;

    private void Update()
    {
        if (_spawnTimer <= _timer)
        {
            EnemyMovementBehaviour spawnEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            spawnEnemy.Target = _enemyTarget;
            spawnEnemy.Damager = _enemyDamger;
            _timer = 0.0F;
        }
        else
            _timer += Time.deltaTime;
    }
}
