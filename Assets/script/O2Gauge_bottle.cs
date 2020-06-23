using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2Gauge_bottle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > -5f)
            {
                v = new Vector3(gameObject.transform.position.x - 0.10f, gameObject.transform.position.y, gameObject.transform.position.z);
                gameObject.transform.position = v;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {

                if (gameObject.transform.position.x < 5f)
                {
                    v = new Vector3(gameObject.transform.position.x + 0.10f, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.position = v;
                }
            }
        }

    }
}
