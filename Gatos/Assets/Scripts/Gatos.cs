using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Gatos : MonoBehaviour
{
    private string _classe;
    public float _vida;
    private float _dano;
    private int _nivel;
    public float _exp;
    //classe
    public string GetClasse() {return _classe; }
    public void SetClasse(string classe) {_classe = classe;}

    //vida
    public float GetVida() {return _vida;}
    public void SetVida(float vida) {_vida = vida;}

    //- ou + vida
    public void LoseVida(float perde) {_vida -= perde;}
    public void GainVida(float ganha) {_vida += ganha;}

    //dano
    public float GetDano() {return _dano; }
    public void SetDano(float dano){_dano = dano;}

    //nivel
    public float GetNivel() {return _nivel; }
    public void SetNivel(int nivel){_nivel = nivel;}
    // cada inimigo dar uma quantidade de exp, que aumenta o nível de acordo
    public void AumNivel(float exp)
    { 
        //vou ver um jeito melhor de fazer isso kkk
        if((exp == 20f ) || (exp == 40f)){
            _nivel = _nivel + 1;
        }

    }



}
