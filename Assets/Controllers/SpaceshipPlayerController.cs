using UnityEngine;

public class SpaceshipPlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float angleSpeed;

    //[SerializeField]
    //GameObject missileLeft;

    //[SerializeField]
    //GameObject missileRight;

    [SerializeField]
    GameObject missileCenter;

    private float moveX, moveZ, hRotation;

    Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        //moveX = Input.mousePosition.x;
        //moveY = Input.mousePosition.y;
        //moveZ = Input.mousePosition.z;

        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();

        transform.Rotate(Vector3.up * angleSpeed * hRotation * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = transform.forward * moveZ * speed;

        rigidBody.MoveRotation(rigidBody.rotation * Quaternion.Euler(0f, angleSpeed * moveX, 0f));
    }

    private void Shoot()
    {
        Instantiate(missileCenter, transform.position, transform.rotation);
    }
}
