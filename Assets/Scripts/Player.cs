using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("bom dia");
    }

    // Update is called once per frame
    void Update()
    {
        //checando se esta sendo apertado seta pra direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        } 
        else if (Input.GetKey(KeyCode.LeftArrow)) //checando se esta sendo apertado seta pra esquerda
        {
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }
    }
}
