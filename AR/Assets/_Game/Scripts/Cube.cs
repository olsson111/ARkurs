using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IDamageable {

    [SerializeField]
    float m_Health = 100f;

    private void OnEnable()
    {
        CubeTrackableEventHandler.OnSendMessage += Reincarnate;
    }

    private void OnDisable()
    {
        CubeTrackableEventHandler.OnSendMessage -= Reincarnate;
    }

    private void Reincarnate(string text)
    {
        if (m_Health <= 0)
        {
            GetComponent<SkinnedMeshRenderer>().material.color = Color.white;
            m_Health = 100;
        }
    }


    public void Damage(float damageValue)
    {
        m_Health -= damageValue;

        if (m_Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        GetComponent<SkinnedMeshRenderer>().material.color = Color.red;
    }
}

public interface IDamageable
{
    void Damage(float damageValue);
    void Die();
}
