using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float angleSpeed;

    private float moveX, moveZ;

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
            animator.SetBool("isJumping", true);

        if (Input.GetKeyUp(KeyCode.Space))
            animator.SetBool("isJumping", false);

    }

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }
}
