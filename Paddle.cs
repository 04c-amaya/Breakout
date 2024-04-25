using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 64)
        {
            transform.Translate(Time.deltaTime * 60, 0, 0);

        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -64)
        {
            transform.Translate(Time.deltaTime * -60, 0, 0);
        }
    }
}
