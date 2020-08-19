using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // runs every frame just like Update(), but is called after Update() --> guarantees that all other objects have been updated
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; //this code is put here to ensure that the player's position has moved before moving the camera
    }
}
