using UnityEngine;
using System;
using System.Collections;

public class Movement : MonoBehaviour {

    public Vector3 direction = Vector3.forward;

    public int speed;

    public Transform enemy;

    private double min = -1;
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = transform.position - enemy.transform.position;
        Time.timeScale = calcTimeScale(distance.sqrMagnitude);
        Debug.Log(Time.timeScale);
        Debug.Log(distance.sqrMagnitude);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private float calcTimeScale(float distanceSqrMagnitude)
    {
        float wanted = (distanceSqrMagnitude - 25000) / 45000;
        if (wanted > 1F)
        {
            return 1F;
        }
        if (wanted < 0.1F)
        {
            return 0.1F;
        }
        return wanted;
    }
}
