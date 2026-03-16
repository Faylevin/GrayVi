using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gato : MonoBehaviour
{
    public Button btn;
    public Text txtJuego;

    private int[,] matrizGato = new int [3, 3];
    private int turno = 0; //Nadie tira
    private int ganador = 0, movimientos = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IniciaGato();    
    }

    public void AsignaTurno(Button btn){
        if (ObtenValoresMatrizGato(btn.name) == 0 && ganador == 0){
            if(turno == 0){
                turno = 1;
            }else if (turno ==1){
                turno = 2;
            }else {
                turno = 1;
            }
            txtJuego.text="Juego en curso";
            DibujaSimbolo(btn,turno);
            EscribeValorMatrizGato(btn.name, turno);
            movimientos++;
            VerificaGanador();
        }
    }

    private void DibujaSimbolo(Button btn,int t){
        if(t==1){
            btn.GetComponentInChildren<TextMeshProUGUI>().text = "X";
        } else {
            btn.GetComponentInChildren<TextMeshProUGUI>().text = "O";   
        }
    }

    private int ObtenValoresMatrizGato(string btn){
        int a = -1;
        switch(btn){
            case"B0":
                a = matrizGato[0,0];
                break;
            case"B1":
                a = matrizGato[0,1];
                break;
            case"B2":
                a = matrizGato[0,2];
                break;
            case"B3":
                a = matrizGato[1,0];
                break;
            case"B4":
                a = matrizGato[1,1];
                break;
            case"B5":
                a = matrizGato[1,2];
                break;
            case"B6":
                a = matrizGato[2,0];
                break;
            case"B7":
                a = matrizGato[2,1];
                break;
            case"B8":
                a = matrizGato[2,2];
                break;
        }
        return a;
        Debug.Log("Btn presionado" + a.ToString());
    }

    private void EscribeValorMatrizGato(string btn, int t){
        switch(btn){
            case"B0":
                matrizGato[0,0] = t;
                break;
            case"B1":
                matrizGato[0,1] = t;
                break;
            case"B2":
                matrizGato[0,2]= t;
                break;
            case"B3":
                matrizGato[1,0]= t;
                break;
            case"B4":
                matrizGato[1,1]= t;
                break;
            case"B5":
                matrizGato[1,2]= t;
                break;
            case"B6":
                matrizGato[2,0]= t;
                break;
            case"B7":
                matrizGato[2,1]= t;
                break;
            case"B8":
                matrizGato[2,2]= t;
                break;
        }
    }

    private void IniciaGato(){
        //Inicia la matriz en 0
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
            matrizGato[i,j] = 0;
            }
        }

        GameObject.Find("B0").GetComponentInChildren<TextMeshProUGUI>().text = "";

        GameObject.Find("B1").GetComponentInChildren<TextMeshProUGUI>().text = "";

        GameObject.Find("B2").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B3").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B4").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B5").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B6").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B7").GetComponentInChildren<TextMeshProUGUI>().text = "";
        
        GameObject.Find("B8").GetComponentInChildren<TextMeshProUGUI>().text = "";
    }

    public void VerificaGanador(){
        if(matrizGato[0,0] ==1 && matrizGato[0,1] ==1 && matrizGato[0,2]==1){
            ganador = 1;
        }
        if(matrizGato[1,0] ==1 && matrizGato[1,1] ==1 && matrizGato[1,2]==1){
            ganador = 1;
        }
        if(matrizGato[2,0] ==1 && matrizGato[2,1] ==1 && matrizGato[2,2]==1){
            ganador = 1;
        }
        if(matrizGato[0,0] ==2 && matrizGato[0,1] ==2 && matrizGato[0,2]==2){
            ganador = 2;
        }
        if(matrizGato[1,0] ==2 && matrizGato[1,1] ==2 && matrizGato[1,2]==2){
            ganador = 2;
        }
        if(matrizGato[2,0] ==2 && matrizGato[2,1] ==2 && matrizGato[2,2]==2){
            ganador = 2;
        }
        // -----------------
        if(matrizGato[0,0] ==1 && matrizGato[1,0] ==1 && matrizGato[2,0]==1){
            ganador =1;
        }
        if(matrizGato[0,1] ==1 && matrizGato[1,1] ==1 && matrizGato[2,1]==1){
            ganador =1;
        }
        if(matrizGato[0,2] ==1 && matrizGato[1,2] ==1 && matrizGato[2,2]==1){
            ganador =1;
        }

        
        if(matrizGato[0,0] ==2 && matrizGato[1,0] ==2 && matrizGato[2,0]==2){
            ganador =2;
        }
        if(matrizGato[0,1] ==2 && matrizGato[1,1] ==2 && matrizGato[2,1]==2){
            ganador =2;
        }
        if(matrizGato[0,2] ==2 && matrizGato[1,2] ==2 && matrizGato[2,2]==2){
            ganador =2;
        }

        //----------------
        if(matrizGato[0,0] ==1 && matrizGato[1,1] ==1 && matrizGato[2,2]==1){
            ganador =1;
        }
        if(matrizGato[0,2] ==1 && matrizGato[1,1] ==1 && matrizGato[2,0]==1){
            ganador =1;
        }
        if(matrizGato[0,0] ==2 && matrizGato[1,1] ==2 && matrizGato[2,2]==2){
            ganador =2;
        }
        if(matrizGato[0,2] ==2 && matrizGato[1,1] ==2 && matrizGato[2,0]==2){
            ganador =2;
        }

        if(ganador == 0 && movimientos == 9){
            txtJuego.text = "EMPATE";
            FindObjectOfType<sonido>().PlayFinJuego();
        }

        if(ganador ==1){
            txtJuego.text = "GANADOR: X";
            FindObjectOfType<sonido>().PlayFinJuego();
        }

        if(ganador ==2){
            txtJuego.text = "GANADOR: O";
            FindObjectOfType<sonido>().PlayFinJuego();
        }
    }

   public void ReiniciaJuego(){
    StartCoroutine(Reiniciar());
    }

    IEnumerator Reiniciar(){
        FindObjectOfType<sonido>().PlayBoton();
         yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("Inicio");
    }
    
}
