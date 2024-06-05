using System.Collections;
using UnityEngine;

public class EnemyRobotSpawnerController : MonoBehaviour
{
    [SerializeField] GameObject enemyRobot;
    [SerializeField] float spawnTime;

    void Start()
    {
        StartCoroutine(SpawnEnemyRobot());
    }

    IEnumerator SpawnEnemyRobot()
    {
        for (; ; )
        {
            Instantiate(enemyRobot, new Vector3(15f, 0.15f, 1f), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}