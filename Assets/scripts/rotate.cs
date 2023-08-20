using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate around - 1st parameter is target
        // rotate around need second parameter about the axi or rotation
        // rotate around need 3rd papameter for the speed of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
