using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 moving = new Vector2();

    void Update()
    {
        // Refactor the code
        // Player only moves left and right
        // Player flys

        moving.x = moving.y = 0;

        if (Input.GetKey("right"))
        {
            moving.x = 1;
        }
        else if (Input.GetKey("left"))
        {
            moving.x = -1;
        }
        else if (Input.GetKey("up"))
        {
            moving.y = 1;
        }
        //else if (Input.GetKey("down") || Input.GetKey("S"))
        //{
        //    moving.y = -1;
        //}
    }
}
