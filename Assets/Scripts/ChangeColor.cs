using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public GameObject Hair;
    private Sprite hosniSprite;
    public Color hosniColor;
    // Start is called before the first frame update
    private void Start()
    {
        hosniSprite = Hair.GetComponent<SpriteRenderer>().sprite;
        hosniColor = Hair.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.yellow;
        }
    }
}
