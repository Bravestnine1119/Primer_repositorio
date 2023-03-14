using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    Collider2D collider;
    public GameManager manager;
    


    // Start is called before the first frame update
    void Start()
    {
        collider = transform.GetComponent<Collider2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colision con " + collision.name);
        if(collision.gameObject.tag == "Player")
        {
            
            
            gameObject.SetActive(false);
            manager.AddScore();
        }
    }
    
}
