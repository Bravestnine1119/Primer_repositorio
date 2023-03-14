using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1;
    void Update()
    { 

    float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    float yMove = Input.GetAxis("Vertical")* Time.deltaTime *speed;

    transform.Translate(new Vector2(xMove, yMove));

    }

    

}
