using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Transform PlayerTransform;
    private Transform PlayerTransformTwo;

    public Transform spawnPoint;
    public Transform spawnPointTwo;
    void Start()
    {
        PlayerTransform = GameObject.Find("playerTest").transform;
        PlayerTransformTwo = GameObject.Find("playerTestTwo").transform;
    }
    void OnTriggerEnter()
    {
        if (PlayerTransform.position.y <= -4)
        {
            PlayerTransform.position = spawnPoint.position;
        }

        if (PlayerTransformTwo.position.y <= -4)
        {
            PlayerTransformTwo.position = spawnPointTwo.position;
        }
    }
}