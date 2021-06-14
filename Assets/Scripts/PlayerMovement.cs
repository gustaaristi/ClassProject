using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{
    earth,
    water,
    fire,
    air
}

public class PlayerMovement : MonoBehaviour
{
    

    [SerializeField]private string playerName = "Cubito";

    [SerializeField] private Material earth;
    [SerializeField] private Material water;
    [SerializeField] private GameObject weapon;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float moveSpeed = 30;
    private bool isGround;

    [SerializeField] private PlayerState playerState = PlayerState.water;

    //Se ejecuta al inicar el juego
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Start se ejecuta antes del primer frame (una vez)
    void Start()
    {
        //GetComponent<MeshRenderer>().material = earth;
        //GetComponent<MeshRenderer>().material.SetColor("_BaseColor", Color.red);
    }

    void OnCollisionStay()
    {
        isGround = true;
    }

    // Update se ejecuta una vez cada fotograma (frame)
    //Es decir, si es juego corre a 60fps, esto se ejecuta 60 veces
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            playerTransform.Rotate(playerTransform.rotation.x, -2, playerTransform.rotation.y, Space.Self);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            playerTransform.Rotate(playerTransform.rotation.x, 2, playerTransform.rotation.y, Space.Self);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) )
        {
            ChangeMaterial();
        }
    }

    private void ChangeMaterial()
    {
        if (playerState == PlayerState.water)
        {
            GetComponent<MeshRenderer>().material = earth;
            playerState = PlayerState.earth;
        }
        else
        {
            GetComponent<MeshRenderer>().material = water;
            playerState = PlayerState.water;
        }

        
    }
}
