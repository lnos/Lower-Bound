using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject camera;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        speed += 0.00008f;
        camera.transform.position += Vector3.up * Time.deltaTime * speed;
    }
}
