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

    private float timeToAttack = 0.25f;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // swordDown = transform.Find("Sword Down").gameObject;
        // swordUp = transform.Find("Sword Up").gameObject;
        // swordLeft = transform.Find("Sword Left").gameObject;
        // swordRight = transform.Find("Sword Right").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
        else if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Space))
        {
            ActivateSword(swordRight);
        }
        else if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
        {
            ActivateSword(swordLeft);
        }
        else if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            ActivateSword(swordDown);
        }
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.Space))
        {
            ActivateSword(swordUp);
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
    }

    private void Attack()
    {
        attacking = true;
        // Activate the default sword for attack
        ActivateSword(swordDown);
    }

    private void ActivateSword(GameObject sword)
    {
        DeactivateAllSwords();
        sword.SetActive(true);
    }

    private void DeactivateAllSwords()
    {
        swordDown.SetActive(false);
        swordUp.SetActive(false);
        swordLeft.SetActive(false);
        swordRight.SetActive(false);
    }
}
