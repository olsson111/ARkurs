using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

    public float m_Damage = 10;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 screenPoint = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenPoint);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                IDamageable dmgbl = hit.collider.GetComponent<IDamageable>();
                if (dmgbl != null)
                {
                    dmgbl.Damage(m_Damage);
                    Debug.Log("Damaged " + hit.collider.name + " with " + m_Damage + " points of damage!");
                }else
                Debug.Log("Didn't find anyting damageable");
            }
        }
	}
}
