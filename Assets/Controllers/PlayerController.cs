using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angleSpeed;

    float moveX, moveZ;
    bool isEnemy = false;

    GameObject? enemy = null;
    Rigidbody rigidBody;
    Animator animator;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
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
                    LevelSceneUiController.Instance.ScoreCount++;
                }
                catch { }
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
            animator.SetBool("isJumping", false);

        if (LevelSceneUiController.Instance.ScoreCount >= 10)
            SceneManager.LoadScene("ComputerTransitionScene");

        if (LevelSceneUiController.Instance.GetDamage() <= 0)
            SceneManager.LoadScene("GameOverScene");
    }

    void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }

    void OnTriggerEnter(Collider other)
    {
        enemy = other.gameObject;

        isEnemy = true;
    }
}