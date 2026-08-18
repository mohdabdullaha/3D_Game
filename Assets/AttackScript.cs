using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttackScript : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position)<3)
        {
            GetComponent<Animator>().Play("Attack");
        }
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.name.StartsWith("Enemy")) 
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
