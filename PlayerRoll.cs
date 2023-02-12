using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoll : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        OnMove();

        FixedUpdate();
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(0); //or whatever number your scene is
        }
    }

    private void OnMove()
    {
        movementY = -Input.GetAxis("Vertical") * 3;

        movementX = -Input.GetAxis("Horizontal") * 3;

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

}