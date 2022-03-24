using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checando se apertou enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //ir para a cena do jogo
            IniciaJogo();
        }
    }

    public void IniciaJogo()
    {
        //ir para a cena do jogo
        SceneManager.LoadScene("Jogo");
    }
}
