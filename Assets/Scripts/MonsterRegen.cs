﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRegen : MonoBehaviour {

	public Transform Background;

	// Use this for initialization
	void Start () {
		NotificationCenter.Instance.Add ("MonsterDie", this.OnMonsterDie);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMonsterDie() {
		StartCoroutine (StartMonsterRegen ());
	}

	public IEnumerator StartMonsterRegen() {
		yield return new WaitForSecondsRealtime (3f);
		GameObject orc = Resources.Load ("Prefabs/Orc") as GameObject;
		Instantiate (orc, Background);
	}
}
