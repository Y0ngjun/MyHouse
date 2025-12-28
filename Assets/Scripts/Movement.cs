using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool up = Input.GetKey(KeyCode.E);
        bool down = Input.GetKey(KeyCode.Q);
        float y = 0;

        if(up && !down)
        {
            y = 1;
        }
        else if(!up && down)
        {
            y = -1;
        }

        transform.Translate(new Vector3(x * 15 * Time.deltaTime, y * 15 * Time.deltaTime, z * 15 * Time.deltaTime));

    }
}
