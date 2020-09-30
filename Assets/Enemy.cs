using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   private TextMeshProUGUI TextHits;
    [SerializeField] private GameObject HitsFX;
    // Start is called before the first frame update
    private void Start()
    {
        TextHits = GameObject.Find("HitsValue").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            HitsCount.Hits++;
            TextHits.text = HitsCount.Hits.ToString();
            Instantiate(HitsFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
