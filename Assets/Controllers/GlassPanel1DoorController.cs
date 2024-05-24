using UnityEngine;

public class GlassPanel1DoorController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private bool isOpen = false;

    //private Vector3 initialRotation;
    //private Vector3 openRotation;

    private int angle;
    private Quaternion rotation;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        //initialRotation = transform.localEulerAngles;

        //openRotation = initialRotation + new Vector3(0, 90, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            isOpen = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            isOpen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            isOpen = false;
    }

    private void Update()
    {
        rotation = Quaternion.Euler(0f, angle, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2);

        if (angle == 90) 
            angle = 0;
        else 
            angle = 90;
         
        //RaycastHit hit;
        //if (Physics.Raycast(transform.position, Vector3.back, out hit, 3f))
        //if (Physics.Raycast(transform.position, Vector3.forward, out hit, 3f))
            
    }
}
