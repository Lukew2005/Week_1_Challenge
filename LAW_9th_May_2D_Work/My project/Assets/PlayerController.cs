using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public int Money = 0;
    public string HitMSG = "Player Hit Bumper";
    // Start is called before the first frame update
    public TMP_Text moneyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Money -= 10;
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bumper"))
        {
            Money += 1;
            Debug.Log(Money);
            moneyText.text = "Money: " + Money.ToString();
        }
    }
}
