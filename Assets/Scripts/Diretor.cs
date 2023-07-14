using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour { 
    [SerializeField] private GameObject GameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;

    public void FinalizarJogo(){
        Time.timeScale = 0;
        //habilitar a imagem Game Over
        this.GameOver.SetActive(true);
    }

    public void Start(){
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void DestruirObstaculos(){
        Obstaculos[] obstaculos = GameObject.FindObjectsOfType<Obstaculos>();
        foreach(Obstaculos obstaculo in obstaculos){
            obstaculo.Destruir();
        }
    } 

    public void ReiniciarJogo() {
        this.GameOver.SetActive(false);
        Time.timeScale = 1;
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.Reiniciar();
    }

}