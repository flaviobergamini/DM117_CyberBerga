using UnityEngine;

public class EnemyRobotController : MonoBehaviour
{
    [SerializeField] float speed;

    Animator anim;

    GameObject player;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Start()
    {
        player = GameObject.Find("PositionForEnemy");
    }


    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        anim.SetBool("Walk_Anim", true);
    }
}