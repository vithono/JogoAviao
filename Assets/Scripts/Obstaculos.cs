using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos: MonoBehaviour {
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float variacaoDaPosicaoY = 1;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

    private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start(){
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Update() {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);


        //Se a minha posicao for menor que a posicao do aviao 
        if(!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x){
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();

        }

    }

    private void OnTriggerEnter2D(Collider2D outro){
        this.Destruir();
    }

    public void Destruir(){
        Destroy(this.gameObject);
    }
}