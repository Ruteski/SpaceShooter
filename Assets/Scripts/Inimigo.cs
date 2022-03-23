using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    //saber quem é meu rigidbody
    public Rigidbody2D meuRB;

    //define a velocidade
    public float velocidade = 2f;


    // Start is called before the first frame update
    void Start()
    {
        //quando iniciar, atribuo velocidade para o rigidbody
        meuRB.velocity = Vector2.down * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
