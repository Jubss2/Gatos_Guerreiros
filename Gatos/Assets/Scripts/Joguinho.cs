using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joguinho : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Guerreiro guer = new Guerreiro();

        guer.SetVida(3);
        guer.SetDano(2);
        guer.SetNivel(1);
        guer.SetClasse("Guerreiro");
        Debug.Log("Vida antes:" + guer.GetVida());
        guer.TakeDamage(2);

        Debug.Log("Vida depois:" +guer.GetVida());
        Debug.Log("Dano: "+guer.GetDano());
        Debug.Log("Nível: "+guer.GetNivel());
        Debug.Log("Classe: "+guer.GetClasse());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
