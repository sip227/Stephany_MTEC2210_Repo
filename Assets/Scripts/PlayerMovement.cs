using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject lilpotatoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }


        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SpawnPiggy();
        }
    }
    
    public void Shoot()
    {
        Debug.Log("Shooting");
    }

    public void SpawnPiggy()
    {
        GameObject lilpotato = Instantiate(lilpotatoPrefab, Vector3.zero, Quaternion.identity);
       // lilpotato.GetComponent<PlayerMovement>().speed = 0;
        lilpotato.GetComponent<PlayerMovement>().enabled = false;
    }


}
