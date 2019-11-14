using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public Transform Player; //Player
    private Vector3 _cameraOffset; //camera

    [Range(0.01f, 1.0f)] //rango del smooth
    public float factor = 0.5f; //valor para smooth

    public float speedH = 2.0f; //velocidad horizontal
    public float speedV = 2.0f; //velocidad vertical

    private float y = 0.0f;
    private float x = 0.0f;


    // Use this for initialization
    void Start()
    {
        _cameraOffset = transform.position - Player.position;
    }

    // Update is called once per frame

    void Update()
    {

        Vector3 newPos = Player.position + _cameraOffset;

        x -= speedV * Input.GetAxis("Mouse Y");
        y += speedH * Input.GetAxis("Mouse X");

        transform.position = Vector3.Slerp(transform.position, newPos, factor);
        transform.eulerAngles = new Vector3(x, y, 0.0f);
        transform.RotateAround(Player.position, transform.right, Input.GetAxis("Mouse Y") * Time.deltaTime);
        transform.RotateAround(Player.position, transform.forward, Input.GetAxis("Mouse X") * Time.deltaTime);

    }
}