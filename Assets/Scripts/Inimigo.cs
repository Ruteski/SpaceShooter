using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inimigo : MonoBehaviour
{
    //saber quem é meu rigidbody
    public Rigidbody2D meuRB;

    //define a velocidade
    public float velocidade = 2f;

    //saber quem é minha explosao
    public GameObject minhaExplosao;


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

    //quando for destruido
    /*private void OnDestroy()
    {

    }*/

    //criando metodo para morte do inimigo
    public void Morrendo()
    {
        GameObject explosao = Instantiate(minhaExplosao, transform.position, transform.rotation);
        Destroy(explosao, 0.4f);
    }

    //checando se um inimigo tocou em um istrigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //identificando se a colisao é o fim do jogo
        if (collision.CompareTag("fim"))
        {
            //reiniciando o jogo, vai para a tela inicial
            SceneManager.LoadScene("Inicio");
        }
    }
}
