using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int Health = 100;

	// Use this for initialization
	void Start () {
		NotificationCenter.Instance.Add ("PlayerAttack", this.OnDamage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnDamage() {
		Health -= DataController.Instance.gameData.Damage;
		if (Health <= 0) {
			OnDie ();
		}
	}

	public void OnDie() {
		NotificationCenter.Instance.Delete ("PlayerAttack", this.OnDamage);
		NotificationCenter.Instance.Notify ("MonsterDie");
		Destroy (gameObject);
	}
}
