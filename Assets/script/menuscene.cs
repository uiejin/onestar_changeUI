using UnityEngine;
using System.Collections;

public class menuscene : MonoBehaviour
{
    public GameObject obj1, obj2;

    void Update()
    {
        Vector3 v;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > -5f)
            {
                v = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                gameObject.transform.position = v;
            }
            if (gameObject.transform.position.x <= -1f)
                Destroy(obj2);
            if (gameObject.transform.position.x <= -5f)
                Application.LoadLevel("gamescene");
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.x < 5f)
                {
                    v = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
                    gameObject.transform.position = v;
                }
                if (gameObject.transform.position.x >= 1f)
                    Destroy(obj1);
                if (gameObject.transform.position.x >= 5f)
                Application.LoadLevel("minishopscene");
            }
        }
    }
}