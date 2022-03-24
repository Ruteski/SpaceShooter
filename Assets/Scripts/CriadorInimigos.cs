using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorInimigos : MonoBehaviour
{

    //quem eu vou criar
    public GameObject inimigo;

    //onde vou criar
    public float xMin = -2.5f;
    public float xMax = 2.5f;
    public float yMin = 6f;
    public float yMax = 9f;

    //tempo para criacao
    public float espera = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fazendo espera acabar
        espera -= Time.deltaTime;

        //quando acabar a espera, cria inimigo
        if (espera <= 0)
        {
            //posicao aleatoria de criacao do inimigo
            Vector3 posicao = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

            //cria o inimigo
            Instantiate(inimigo, posicao, Quaternion.identity);

            //reseta a espera
            espera = 3;
        }
    }
}
