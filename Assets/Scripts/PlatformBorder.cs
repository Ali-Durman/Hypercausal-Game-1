using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBorder : MonoBehaviour
{
    public float minX;
    public float maxX;

    void Update()
    {
        float xPos = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(xPos,transform.position.y,transform.position.z);
    }
}
