using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerreiro : Gatos, ITakeDamage
{
    // Ataque - Guerreiro pode jogar a sua espada em inimigos dar um dano em aréa (se possivel tem q pegar ela devolta se n ele brota de novo nele);
    // Exploração - ganha + exp;

    public void MaisExp(float mexp)
    {
        float x;
        //n lembro muito bem se era assim q funcionava :O
        _exp = mexp;
        x = mexp * 1.1f;
        _exp = x;
        
    }

    public void TakeDamage(float danot)
    {
        _vida -= danot;
    }
 
    
}
