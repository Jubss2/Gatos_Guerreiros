using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Diagnostics;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class Gatos : MonoBehaviour
{

    private string _classe;
    public float _vida;
    private float _dano;
    private int _nivel;
    public float _exp;


    public bool isJumping;
    private Animator anim;
    private Rigidbody rig;
    public float Speed;
    public float JumpForce;

    #region gato
    
    public string GetClasse() {return _classe; }
    public void SetClasse(string classe) {_classe = classe;}

   
    public float GetVida() {return _vida;}
    public void SetVida(float vida) {_vida = vida;}

 
    public void LoseVida(float perde) {_vida -= perde;}
    public void GainVida(int ganha) {_vida += ganha;}

  
    public float GetDano() {return _dano; }
    public void SetDano(float dano){_dano = dano;}

    
    public float GetNivel() {return _nivel; }
    public void SetNivel(int nivel){_nivel = nivel;}
    // cada inimigo dar uma quantidade de exp, que aumenta o nível de acordo
    public void AumNivel(float exp)
    { 
        
        if((exp == 20f ) || (exp == 40f)){
            _nivel = _nivel + 1;
        }

    }
    #endregion

      void Start()
    {   
       
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
        Move();
        Jump();
       
    }


    void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if(Input.GetAxis("Horizontal") > 0f )
        {
        

        transform.eulerAngles = new Vector3 (0f,0f,0f);
        }    
        if(Input.GetAxis("Horizontal") < 0f )
        {
        
        transform.eulerAngles = new Vector3 (0f,180f,0f);
        }    
        if(Input.GetAxis("Horizontal") == 0f )
        {
       
        }    

    }

    void Jump() {
        if(Input.GetButtonDown("Jump") && !isJumping){
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode.Impulse);
            //pulo duplo ou um só?
            anim.SetBool("pulo",true);
            isJumping = true;

        }
       
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.layer == 3){
            isJumping = false;
            anim.SetBool("pulo", false);
        }    
    }


}
