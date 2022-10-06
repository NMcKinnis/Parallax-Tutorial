using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }
}
