using UnityEngine;

public class EnemyRobotController : MonoBehaviour
{
    [SerializeField]
    float speed;

    GameObject player;

    void Start()
    {
        player = GameObject.Find("PositionForEnemy");
    }


    void Update()
    {
        transform.LookAt(player.transform.position);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
