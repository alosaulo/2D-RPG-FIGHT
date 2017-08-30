using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    enum EstadoAtack
    {
        Esquerda,
        Direita,
        Cima,
        Baixo
    }


    enum estadoPersonagem {
        ParadoBaixo,
        ParadoCima,
        ParadoEsquerda,
        ParadoDireita,
        AndandoBaixo,
        AndandoCima,
        AndandoEsquerda,
        AndandoDireita
    }

    public float raycastDistance;
    
    public float raycastOffset;

    public float Speed;
    
    private bool _isAttacking = false;
    
    float horAxis;
    float verAxis;

    [Range(-1.0f,1.0f)]
    public float deadPoint = 0.2f;

    EstadoAtack estadoAtack;
    estadoPersonagem estadoAtual;

    [HideInInspector]
	public Collider2D myCollider;
	Rigidbody2D myBody;
    Animator myAnimator;

	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        horAxis = Input.GetAxis("Horizontal");
        verAxis = Input.GetAxis("Vertical");
	    //Debug.Log(estadoAtual);
	    AttackingAnimation();
        ChangeAnimationBlendTree();
        //ChangeAnimation();
	}

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement() {
        if (horAxis != 0) {
            myBody.AddForce((Vector3.right * horAxis) * Speed);
            if (horAxis > deadPoint){
                estadoAtual = estadoPersonagem.AndandoDireita;
                estadoAtack = EstadoAtack.Direita;
            }
            if (horAxis < deadPoint)
            {
                estadoAtual = estadoPersonagem.AndandoEsquerda;
                estadoAtack = EstadoAtack.Esquerda;
            }
        }
        if (verAxis != 0) {
            myBody.AddForce((Vector3.up * verAxis) * Speed);
            if (verAxis > deadPoint)
            {
                estadoAtual = estadoPersonagem.AndandoCima;
                estadoAtack = EstadoAtack.Cima;
            }
            if (verAxis < deadPoint)
            {
                estadoAtual = estadoPersonagem.AndandoBaixo;
                estadoAtack = EstadoAtack.Baixo;
            }
        }
        if (Mathf.Abs(verAxis) <= deadPoint && Mathf.Abs(horAxis) <= deadPoint) {
            if (myAnimator.GetFloat("inputX") > 0)
            {
                estadoAtual = estadoPersonagem.ParadoDireita;
                estadoAtack = EstadoAtack.Direita;
            }
            else
            {
                estadoAtual = estadoPersonagem.ParadoEsquerda;
                estadoAtack = EstadoAtack.Esquerda;
            }
            if (myAnimator.GetFloat("inputY") > 0)
            {
                estadoAtual = estadoPersonagem.ParadoCima;
                estadoAtack = EstadoAtack.Cima;
            }
            else
            {
                if (myAnimator.GetFloat("inputY") < 0) { 
                    estadoAtual = estadoPersonagem.ParadoBaixo;
                    estadoAtack = EstadoAtack.Baixo;
                }
            }
        }
    }

    void ChangeAnimationBlendTree() {
        if(Mathf.Abs(horAxis) >= deadPoint ||
            Mathf.Abs(verAxis) >= deadPoint) { 
            myAnimator.SetFloat("inputX", horAxis);
            myAnimator.SetFloat("inputY", verAxis);
        }
        if (estadoAtual == estadoPersonagem.ParadoBaixo || estadoAtual == estadoPersonagem.ParadoCima ||
            estadoAtual == estadoPersonagem.ParadoDireita || estadoAtual == estadoPersonagem.ParadoEsquerda)
            myAnimator.SetBool("parado",true);
        else
            myAnimator.SetBool("parado", false);
    }

    private void AttackingAnimation()
    {
        if (Input.GetAxis("Fire1") != 0 && _isAttacking == false)
        {
            _isAttacking = true;
            myAnimator.SetTrigger("atk");
            AnimatorStateInfo atkState = myAnimator.GetCurrentAnimatorStateInfo(0);
            float aLength = atkState.length;
            StartCoroutine("Attack",0.8f);
        }
    }

    private IEnumerator Attack(float aLength)
    {
        RayCastAttack();
        yield return new WaitForSeconds(aLength);
        _isAttacking = false;
    }

    public void RayCastAttack(){
        RaycastHit2D hit;
        Vector2 offsetVecPosition;
        switch (estadoAtack)
        {
            case EstadoAtack.Cima:
                offsetVecPosition = new Vector2(transform.position.x,
                    transform.position.y + raycastOffset);
                hit = Physics2D.Raycast(offsetVecPosition, Vector2.up * raycastDistance);
                Debug.DrawRay(offsetVecPosition, Vector2.up * raycastDistance,Color.cyan,3f);
                break;
            case EstadoAtack.Baixo:
                offsetVecPosition = new Vector2(transform.position.x,
                    transform.position.y - raycastOffset);
                hit = Physics2D.Raycast(offsetVecPosition, Vector2.down * raycastDistance);
                Debug.DrawRay(offsetVecPosition, Vector2.down * raycastDistance,Color.cyan,3f);
                break;
            case EstadoAtack.Esquerda:
                offsetVecPosition = new Vector2(transform.position.x - raycastOffset,
                    transform.position.y);
                hit = Physics2D.Raycast(offsetVecPosition, Vector2.left * raycastDistance);
                Debug.Log(hit.collider.name);
                Debug.DrawRay(offsetVecPosition, Vector2.left * raycastDistance, Color.cyan, 3f);
                break;
            case EstadoAtack.Direita:
                offsetVecPosition = new Vector2(transform.position.x + raycastOffset,
                    transform.position.y);
                hit = Physics2D.Raycast(offsetVecPosition, Vector2.right * raycastDistance);
                Debug.DrawRay(offsetVecPosition, Vector2.right * raycastDistance,Color.cyan,3f);
                break;
        }
        Debug.Log(estadoAtack);
    }    
}
