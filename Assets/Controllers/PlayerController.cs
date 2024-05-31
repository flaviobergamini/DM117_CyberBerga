using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float angleSpeed;

    private float moveX, moveZ;

    GameObject? enemy = null;

    bool isEnemy = false;

    Rigidbody rigidBody;

    Animator animator;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        if (moveZ != 0)
            animator.SetBool("isWalking", true);
        else
            animator.SetBool("isWalking", false);

        if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 2;

            animator.SetBool("isRunning", true);
        }

        if (Input.GetKeyUp(KeyCode.RightShift) || Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= 2;

            animator.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
            
            if (enemy != null && isEnemy && enemy.CompareTag("Robot"))
            {
                try
                {
                    Destroy(enemy);
                    isEnemy = false;
                    Debug.Log("Comeu o Robo inimigo");
                }
                catch { }
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
            animator.SetBool("isJumping", false);
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }


    private void OnTriggerEnter(Collider other)
    {
        enemy = other.gameObject;

        isEnemy = true;     
    }

    /*void LostLife()
    {
        var distanceX = Mathf.Abs(Mathf.Abs(enemy.transform.position.x) - Mathf.Abs(this.transform.position.x));
        var distanceZ = Mathf.Abs(Mathf.Abs(enemy.transform.position.z) - Mathf.Abs(this.transform.position.z));

        if (!isEnemy && distanceX < 0.5 && distanceZ < 0.5 && enemy != null && enemy.CompareTag("Robot"))
        {
            Debug.Log("Perdeu uma vida");
            Destroy(enemy);
        }
    }*/
}
