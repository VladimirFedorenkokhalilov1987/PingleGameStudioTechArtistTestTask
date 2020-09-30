using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        var Enemy = Instantiate(_enemy, new Vector3(Random.Range(220, 650), 7, Random.Range(250, 640)),
            Quaternion.identity);
        Enemy.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(5);
        StartCoroutine(SpawnEnemy());
    }
}
