using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceStart : MonoBehaviour
{
    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            square.GetComponent<Rigidbody2D>().simulated = true;
        }
    }
}
