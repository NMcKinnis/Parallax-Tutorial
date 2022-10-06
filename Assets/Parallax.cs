using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Camera mainCamera;
    public Transform player;
    Vector2 startPosition;
    float startZPosition;

    Vector2 travel => (Vector2)mainCamera.transform.position - startPosition;
    float distanceToPlayer => transform.position.z - player.position.z;
    float clippingPlane => (mainCamera.transform.position.z) + (distanceToPlayer > 0 ? mainCamera.farClipPlane : mainCamera.nearClipPlane);
    float parallaxFactor => Mathf.Abs(distanceToPlayer / clippingPlane);
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startZPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startPosition + travel * parallaxFactor;
        transform.position = new Vector3(newPos.x, newPos.y, startZPosition);
    }
}
