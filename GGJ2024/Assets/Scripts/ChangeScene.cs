using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string cena)
    {


        GameManager.luzesAcesas = 0;
        DragDrop.canosConectados = 0;
        Vencer.porta = 0;
        SceneManager.LoadScene("GamePause");

    }

    public void Voltar(string cena)
    {
        SceneManager.LoadScene("Menu");
    }

    public void Creditos(string cena)
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Tutorial(string cena)
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Sair(string cena)
    {
        Application.Quit();
    }
}
