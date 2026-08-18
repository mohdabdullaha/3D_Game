using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet, explosion;
    GameObject launcher, expoposition;
    // Start is called before the first frame update
    void Start()
    {
        launcher = GameObject.Find("Launcher");
        expoposition = GameObject.Find("Explosion");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Quaternion rotate = launcher.transform.rotation;
            Instantiate(bullet, launcher.transform.position, rotate);
            Instantiate(explosion, expoposition.transform.position, expoposition.transform.rotation);
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name.Equals("Win"))
    //    {
    //        SceneManager.LoadScene("YouWin");
    //    }
    //}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name.Equals("Win"))
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}