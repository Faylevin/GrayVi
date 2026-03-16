using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Navegacion : MonoBehaviour
{
    public void IrAInicio()
    {
        StartCoroutine(CambiarEscena("Inicio"));
    }

    public void Regresar()
    {
        StartCoroutine(CambiarEscena("Main"));
    }

    public void Salir()
    {
        StartCoroutine(SalirJuego());
    }

    IEnumerator CambiarEscena(string escena)
    {
        FindObjectOfType<sonido>().PlayBoton();
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(escena);
    }

    IEnumerator SalirJuego()
    {
        FindObjectOfType<sonido>().PlayBoton();
        yield return new WaitForSeconds(0.3f);
        Application.Quit();
    }
}