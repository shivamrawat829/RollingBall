using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  //  public VirtualJoystick1 joystick;
    public VirtualJoystick1 movejoystick;
    //  public float speed = 150.0f;
    // private Rigidbody rigid;
    public float movespeed = 5.0f;
    public float drag = 0.5f;
    public float terinationRotationSpeed = 25.0f;
    private Rigidbody controller;
    private Transform camTransform;
    public float boostSpeed = 5.0f;
    public float boostCoolDown = 2.0f;
    private float lastBoost;

    private void Start()
    {


        lastBoost = Time.time - boostCoolDown;
        // rigid = GetComponent<Rigidbody>();
        controller = GetComponent<Rigidbody>();
        controller.maxAngularVelocity = terinationRotationSpeed;
        controller.drag = drag;

        camTransform = Camera.main.transform;
    }

    private void Update()
    {
        //   rigid.AddForce(joystick.InputDirection * speed * Time.deltaTime);
        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (dir.magnitude > 1)
            dir.Normalize();

        if (movejoystick.InputDirection != Vector3.zero)
        {
            dir = movejoystick.InputDirection;
        }

        Vector3 rotateddir = camTransform.TransformDirection(dir);
        rotateddir = new Vector3(rotateddir.x, 0, rotateddir.z);
        rotateddir = rotateddir.normalized * dir.magnitude;

        controller.AddForce(rotateddir * movespeed);
    }


    public void Boost()
    {

        if (Time.time - lastBoost > boostCoolDown)
        {
            controller.AddForce(controller.velocity.normalized * boostSpeed, ForceMode.VelocityChange);
            lastBoost = Time.time;
        }

        else
        {

            //dont do anything
        }



    }
}

