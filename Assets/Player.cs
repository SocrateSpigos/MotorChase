﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
	public GameObject healthUI;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}

		if (currentHealth <= 0)
        {
			healthUI.SetActive(false);
        }
    }


	public void OnMouseDown()
	{
		TakeDamage(20);
		healthUI.SetActive(true);

	}


	void TakeDamage(int damage)
   {
    
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
 	}

	public void Die()
    {
		currentHealth -= 1000;

		Destroy(healthUI);
	}

}
