using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 10.0f)));
        transform.LookAt(target);
    }
}