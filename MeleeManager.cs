/* 
Author: Noah Wilson
Title: MeleeManager for Game Design class


How to fix clipping: -- Reminder to me
set clipping planes from fpsCam to 0.05

*/
using System.Collections
using System.Collections.Generic;
using UnityEngine;

public class MeleeManager : MonoBehaviour {
	public Camera fpsCam;
	public float range;
	public LayerMask myLayerMask;
	public int damage = 10;
	public int health = 100;
	
	void Start() {
		
	}
	
	void Update() {
		if (Input.GetButtonDown("Fire1"))){
			Attack();
		}
	}
	
	void Attack() {
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forwardm out hit, range, myLayerMask)){
			Target target = hit.transform.gameObject.GetComponent<EnemyManager>();
			if (Target != null){
				/* 
				testing 
				Debug.Log(enemy hit);
				*/
				target.TakeDamage(damage);
			}
			/*
			testing
			Debug.Log(hit.transform.name);
			*/
		}
	}
	
	void TakeDamage(amount) {
		health -= amount;
		if (health <= 0){
			Debug.Log("You are DEAD");
		}
	}
}
