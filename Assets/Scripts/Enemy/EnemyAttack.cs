﻿using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

    public Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void OnCollisionStay () {
        anim.SetTrigger("Attack");
    }
}
