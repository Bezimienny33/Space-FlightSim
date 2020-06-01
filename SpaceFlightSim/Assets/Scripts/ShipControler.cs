using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControler : MonoBehaviour
{
    [SerializeField]
    ShipMovement shipMovement;

    [SerializeField]
    float forwardForce = 10000f;
    [SerializeField]
    float backwardForce = 10000f;
    [SerializeField]
    float upForce = 10000f;
    [SerializeField]
    float rightForce = 10000f;
    [SerializeField]
    public float rollRate = 10000f;
    [SerializeField]
    public float turnRate = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.name + " initialized in : " + gameObject.name);
        shipMovement.forwardForce = forwardForce;   
        shipMovement.backwardForce = backwardForce;   
        shipMovement.upForce = upForce;   
        shipMovement.rightForce = rightForce;  
        shipMovement.rollRate = rollRate;
        shipMovement.turnRate = turnRate; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            shipMovement.MoveRight(Input.GetAxis("Horizontal"));
        }
        if(Input.GetAxis("Vertical") != 0)
        {
            shipMovement.MoveForward(Input.GetAxis("Vertical"));
        }
        if(Input.GetAxis("UpDown") != 0)
        {
            shipMovement.MoveUp(Input.GetAxis("UpDown"));
        }
        if(Input.GetAxis("Roll") != 0)
        {
            shipMovement.Roll(Input.GetAxis("Roll"));
        }
        Vector2 turn;
        turn = new Vector2(Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse X"));
        shipMovement.Turn(turn);
    }
}
