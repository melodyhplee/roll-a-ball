using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    // Because the Pick Up cubes use this, need to add Rigidbody to the cubes so Unity doesn't need to update static colliders every frame
    // by adding Rigidbody, the Pick Up cubes become Dynamic Colliders instead of Static Colliders
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}


//Kinematic rigibodies are not affected by physic forces - they are moved using transforms