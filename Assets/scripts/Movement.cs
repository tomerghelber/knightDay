using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Vector3 direction = Vector3.forward;

    public int speed;

    public Transform enemy;
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = transform.position - enemy.transform.position;
        if (distance.sqrMagnitude > 400)
        {
            Time.timeScale = 1F;
        }
        else if (distance.sqrMagnitude > 200)
        {
            Time.timeScale = 0.5F;
        }
        else
        {
            Time.timeScale = 0.1F;
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
