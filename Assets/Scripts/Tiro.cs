using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float velocidade = 5f;
    public Rigidbody2D meuRB;

    // Start is called before the first frame update
    void Start()
    {
        meuRB.velocity = Vector2.up * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //meu evento de trigger com o inimigo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //chamando o metodo de morte do inimigo
        //collision = quem eu colidi
        collision.GetComponent<Inimigo>().Morrendo();

        //esse evento vai rodar sempre que ele tiver uma colisao com alguem
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
