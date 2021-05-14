using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyaTest : MonoBehaviour
{
    public float speed = 1;
    public CharacterController chaController;
    // Start is called before the first frame update
    void Start()
    {
        chaController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Horizontal");

        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxis("Vertical"));
        Debug.Log(Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        Debug.Log(Input.GetAxis("Vertical") * speed * Time.deltaTime);
        chaController.Move(
            new Vector3(
                Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                0,
                Input.GetAxis("Vertical") * speed * Time.deltaTime
            )
        );
        
    }
}
