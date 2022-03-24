using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variavel de velocidade
    public float velocidade = 3f;

    //descobrindo quem é meu tiro
    public GameObject meuTiro;

    public float xMin = -2.2f;
    public float xMax = 2.2f;

    public AudioClip somTiro;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("bom dia");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimento = transform.position;

        //checando se esta sendo apertado seta pra direita
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position = new Vector3(transform.position.x + velocidade, transform.position.y, transform.position.z);
            //aplicando velocidade e garantindo que ela nao depende do fps do jogo
            movimento.x += velocidade * Time.deltaTime;
        } 
        
        if (Input.GetKey(KeyCode.LeftArrow)) //checando se esta sendo apertado seta pra esquerda
        {
            //transform.position = new Vector3(transform.position.x - velocidade, transform.position.y, transform.position.z);
            movimento.x -= velocidade * Time.deltaTime;
        }*/

        //refazendo a movimentacao horizontal
        movimento.x += Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;

        //garantindo que o player nao saia  do limite X da tela
        movimento.x = Mathf.Clamp(movimento.x, xMin, xMax);

        //criando o tiro
        if (Input.GetButtonDown("Fire1"))
        {
            //criando o meu tiro
            Instantiate(meuTiro, transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(somTiro, Vector3.zero);
        }

        transform.position = movimento;
    }
}
