using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceshipPlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angleSpeed;
    [SerializeField] GameObject missile;

    float moveX, moveZ;

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();

        if (LevelSpaceSceneUIController.Instance.ScoreCount >= 10)
            SceneManager.LoadScene("ConclusionScene");

        if (LevelSpaceSceneUIController.Instance.GetDamage() <= 0)
            SceneManager.LoadScene("GameOverScene");
    }

    void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }

    void Shoot()
    {
        Instantiate(missile, transform.position, transform.rotation);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemySpaceship"))
        {
            LevelSpaceSceneUIController.Instance.TakeDamage();
            Destroy(other.gameObject);
        }
    }
}