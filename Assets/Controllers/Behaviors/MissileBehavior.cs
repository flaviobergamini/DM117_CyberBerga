using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehavior : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float lifeSpan;

    void Start()
    {
        Invoke(nameof(SelfDestroy), lifeSpan);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemySpaceship"))
        {
            LevelSpaceSceneUIController.Instance.ScoreCount++;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    void SelfDestroy()
    {
        Destroy(this.gameObject);
    }
}
