using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    // Use this for initialization
    public float ySpeed = 100.0f;
    public float xSpeed = 100.0f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, ySpeed * Time.deltaTime,0);
        if (Input.GetMouseButton(0))
            {
            float h = xSpeed * Input.GetAxis("Mouse X");
            float v = ySpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(-v, -h, 0);
            }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ySpeed += 10.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ySpeed -= 10.0f;
        }
        
    }

}