using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int MoveY = 0;
        int MoveX = 0;
        if (Input.GetKey("w"))
        {
            MoveY = 1;
        }
        if (Input.GetKey("a"))
        {
            MoveX = -1;
        }
        if (Input.GetKey("s"))
        {
            MoveY = -1;
        }
        if (Input.GetKey("d"))
        {
            MoveX = 1;
        }

        Vector3 Move = new Vector3(MoveX, MoveY, 0f);
        transform.Translate(Move * 5 * Time.deltaTime);
    }
}
