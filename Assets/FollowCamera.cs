using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    [SerializeField] GameObject thingToFollow;
    // The camera position should be the same as the car's position

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -100);
    }
}
