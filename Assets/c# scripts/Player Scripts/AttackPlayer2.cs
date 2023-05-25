using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer2 : MonoBehaviour
{
    public GameObject swordDown;
    public GameObject swordUp;
    public GameObject swordLeft;
    public GameObject swordRight;

    private bool attacking = false;
    private GameObject activeSword = null;

    private float timeToAttack = 0.25f;
    private float timer = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                DeactivateAllSwords();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                ActivateSword(swordUp);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                ActivateSword(swordLeft);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                ActivateSword(swordDown);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                ActivateSword(swordRight);
            }
        }
    }

    private void Attack()
    {
        if (activeSword != null)
        {
            attacking = true;
            activeSword.SetActive(true);
        }
    }

    private void ActivateSword(GameObject sword)
    {
        DeactivateAllSwords();
        activeSword = sword;
    }

    private void DeactivateAllSwords()
    {
        if (activeSword != null)
        {
            activeSword.SetActive(false);
            activeSword = null;
        }
    }
}
