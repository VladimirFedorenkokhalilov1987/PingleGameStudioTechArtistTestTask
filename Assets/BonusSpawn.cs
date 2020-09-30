using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _bonus;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBonus());
    }

    IEnumerator SpawnBonus()
    {
        var Bonus = Instantiate(_bonus, new Vector3(Random.Range(220, 650), 7, Random.Range(250, 640)),
            Quaternion.identity);
        Bonus.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnBonus());
    }
}
