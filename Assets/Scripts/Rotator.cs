using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;
    private void Start()
    {
        speed = Random.Range(0.5f, 3f);
    }
    // Update is called once per frame
    void Update()
    {
        float rotatingSpeed = 45 * speed * Time.deltaTime;
        transform.Rotate(0, 0, 45);
    }
}
