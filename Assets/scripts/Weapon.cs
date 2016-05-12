using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    /*public int speed = 1; //how fast the object should rotate

	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, transform.position.z - Camera.main.transform.position.z));

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2((screenPos.y - transform.position.y), (screenPos.x - transform.position.x)) * Mathf.Rad2Deg));
    }*/

    //Public Vars
    public Camera camera;
    public float speed;

    //Private Vars
    private Vector3 mousePosition;
    private Vector3 direction;
    private float distanceFromObject;

    void Update()
    {
        Debug.Log(Input.mousePosition);

        //Grab the current mouse position on the screen
        mousePosition = Input.mousePosition;

        //Rotates toward the mouse
        GetComponent<Rigidbody>().transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x)) * Mathf.Rad2Deg - 90);

        //Judge the distance from the object and the mouse
        distanceFromObject = (Input.mousePosition - camera.WorldToScreenPoint(transform.position)).magnitude;

        //Move towards the mouse
        GetComponent<Rigidbody>().AddForce(direction * speed * distanceFromObject * Time.deltaTime);

    }//End Fire3 If case
}
