using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextBonuses;
    [SerializeField] private GameObject BonusFX;
    // Start is called before the first frame update
    private void Start()
    {
        TextBonuses = GameObject.Find("BonusValue").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BonusesCount.Bonuses++;
            TextBonuses.text = BonusesCount.Bonuses.ToString();
            Instantiate(BonusFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
