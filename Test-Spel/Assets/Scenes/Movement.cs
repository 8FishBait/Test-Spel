using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

// Update is called once per frame
void Update()
    {
    int MoveY = 0;
    int MoveX = 0;
        if(Input.GetKey("W"))
        {
        MoveY = 1;
        }
        if (Input.GetKey("A"))
        {
        MoveX = 1;
    }
        if (Input.GetKey("S"))
        {
        MoveY = 1;
    }
        if (Input.GetKey("D"))
        {
        MoveX = 1;
    }

    Vector3 Move = new Vector3(MoveX, MoveY, 0f);
    transform.Translate = Move * Time.deltaTime;
    }
}
