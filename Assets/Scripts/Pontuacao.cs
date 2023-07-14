using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pontuacao : MonoBehaviour {
    private int pontos;
    [SerializeField] private TextMeshProUGUI TextoPontuacao;
    private AudioSource audioAcerto;

    private void Awake(){
        this.audioAcerto = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        this.TextoPontuacao.text = this.pontos.ToString();
        this.audioAcerto.Play();
    } 

    public void Reiniciar(){
        this.pontos = 0;
        this.TextoPontuacao.text = this.pontos.ToString();
    }

}