using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Rigidbody rb;

    public float forwardForce;
    public float backwardForce;
    public float upForce;
    public float rightForce;
    public float rollRate;
    public float turnRate;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Debug.Log(this.name + " initialized in : " + gameObject.name);  
    }
    public void MoveForward(float value)
    {
        if(value > 0)
        {
        rb.AddForce(transform.forward*value*forwardForce*Time.deltaTime,ForceMode.Force);
        }else
        {
        rb.AddForce(transform.forward*value*forwardForce*Time.deltaTime,ForceMode.Force);
        }
    }
    public void MoveRight(float value)
    {
        rb.AddForce(transform.right*value*rightForce*Time.deltaTime,ForceMode.Force);
    }
    public void MoveUp(float value)
    {
        rb.AddForce(transform.up*value*upForce*Time.deltaTime,ForceMode.Force);
    }
    public void Roll(float value)
    {
        rb.AddTorque(Vector3.forward*value*rollRate*Time.deltaTime,ForceMode.Force);
    }
    public void Turn(Vector2 value)
    {
        rb.AddTorque(value*turnRate*Time.deltaTime,ForceMode.Force);
    }
}
