using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksDestroyer : MonoBehaviour {

	[SerializeField] float m_lifeTime;

	public float m_curTime;


	void Update () {

		if (m_curTime < m_lifeTime) {

			m_curTime += Time.deltaTime;
		} else {

			m_curTime = 0f;
			gameObject.SetActive (false);
		}
	}
}
