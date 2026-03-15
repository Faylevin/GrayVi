using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void IrAInicio()
    {
        SceneManager.LoadScene("Inicio");
    }

     public void Regresar()
    {
        SceneManager.LoadScene("Main");
    }

     public void Salir()
    {
        Application.Quit();
    }
}
