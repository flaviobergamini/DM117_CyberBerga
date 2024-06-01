using UnityEngine;

public class SpaceshipPlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float angleSpeed;

    [SerializeField]
    GameObject missile;

    private float moveX, moveZ;

    Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }

    private void Shoot()
    {
        Instantiate(missile, transform.position, transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemySpaceship"))
        {
            LevelSpaceSceneUIController.Instance.TakeDamage();
            Destroy(other.gameObject);
        }
    }
}
