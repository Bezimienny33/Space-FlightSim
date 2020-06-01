using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    new Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.name + " initialized in : " + gameObject.name);  
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
