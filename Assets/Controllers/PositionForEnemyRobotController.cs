using UnityEngine;

public class PositionForEnemyRobotController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var enemy = other.gameObject;

        if (enemy.CompareTag("Robot"))
        {
            LevelSceneUiController.Instance.TakeDamage();

            Destroy(enemy);
        }
    }
}
