using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFierworks : MonoBehaviour {

	[SerializeField] Animator m_skyCar;
	[SerializeField] Transform m_car;
	[SerializeField] GameObject[] m_fireworks;
	public float m_curTime;

	void Start () {

		m_skyCar = m_car.GetComponent<Animator> ();
	}


	void Update () {

		foreach (GameObject o in m_fireworks) {
			
			if (!o.activeSelf)
				
				o.SetActive (m_skyCar.GetCurrentAnimatorStateInfo (0).normalizedTime % 1f > .5f && m_skyCar.GetCurrentAnimatorStateInfo (0).normalizedTime % 1f < .6f);
		}
	}
}
