using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    enum estadoPersonagem {
        parado,
        baixo,
        cima,
        esquerda,
        direita
    }

    public float Speed;
    
    private bool _isAttacking = false;
    
    float horAxis;
    float verAxis;

    [Range(-1.0f,1.0f)]
    public float deadPoint = 0.2f;

    public GameObject Body;
    public GameObject Head;

    estadoPersonagem estadoAtual;

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
            if (horAxis > deadPoint)
                estadoAtual = estadoPersonagem.direita;
            if (horAxis < deadPoint)
                estadoAtual = estadoPersonagem.esquerda;
        }
        if (verAxis != 0) {
            myBody.AddForce((Vector3.up * verAxis) * Speed);
            if (verAxis > deadPoint)
                estadoAtual = estadoPersonagem.cima;
            if (verAxis < deadPoint)
                estadoAtual = estadoPersonagem.baixo;
        }
        if (Mathf.Abs(verAxis) <= deadPoint && Mathf.Abs(horAxis) <= deadPoint) {
            estadoAtual = estadoPersonagem.parado;
        }
    }

    void ChangeAnimationBlendTree() {
        if(Mathf.Abs(horAxis) >= deadPoint ||
            Mathf.Abs(verAxis) >= deadPoint) { 
            myAnimator.SetFloat("inputX", horAxis);
            myAnimator.SetFloat("inputY", verAxis);
        }
        if (estadoAtual == estadoPersonagem.parado)
            myAnimator.SetBool("parado",true);
        else
            myAnimator.SetBool("parado", false);
    }

    private void AttackingAnimation()
    {
        if (Input.GetAxis("Fire1") != 0 && _isAttacking == false)
        {
            myAnimator.SetTrigger("atk");
            AnimatorStateInfo atkState = myAnimator.GetCurrentAnimatorStateInfo(0);
            float aLength = atkState.length;
            StartCoroutine("Attack",aLength);
        }
    }

    private IEnumerator Attack(float aLength)
    {
        _isAttacking = true;
        yield return new WaitForSeconds(aLength);
        _isAttacking = false;
    }

    void ChangeAnimation() {
        switch (estadoAtual) {
            case estadoPersonagem.parado:
                myAnimator.SetBool("parado",true);
            break;
        }
    }


}
