using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLeftBehavior : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        transform.Translate(Vector3.fwd * speed * Time.deltaTime);
    }
}
