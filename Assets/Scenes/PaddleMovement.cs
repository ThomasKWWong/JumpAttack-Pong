using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovementr : MonoBehaviour
{
    public float speed = 10f;
    public string inputAxis;

    void Update()
    {
        float move = Input.GetAxis(inputAxis) * speed * Time.deltaTime;
        transform.Translate(0, move, 0);

        float clampedY = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
        transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
    }
}
