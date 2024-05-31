using UnityEngine;

public class EnemySpaceshipController : MonoBehaviour
{
    [SerializeField] 
    float speed;
    
    GameObject player;

    void Start()
    {
        player  = GameObject.Find("SpaceshipPlayer");
    }


    void Update()
    {
        transform.LookAt(player.transform.position);

        if(transform.position == player.transform.position)
        {
            Destroy(this.gameObject);
            
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
