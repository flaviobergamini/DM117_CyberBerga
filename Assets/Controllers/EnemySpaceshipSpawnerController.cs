using System.Collections;
using UnityEngine;

public class EnemySpaceshipSpawnerController : MonoBehaviour
{
    [SerializeField] GameObject enemySpaceship;
    [SerializeField] float spawnTime;

    void Start()
    {
        StartCoroutine(SpawnEnemySpaceship());
    }

    IEnumerator SpawnEnemySpaceship()
    {
        var random = Random.Range(30, 80);

        for (; ; )
        {
            Instantiate(
                enemySpaceship,
                new Vector3(Random.Range(30, 80), 0, Random.Range(30, 80)),
                Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
