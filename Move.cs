using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public int xVelocity, yVelocity;

    public void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        //offset = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVelocity, yVelocity);
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}