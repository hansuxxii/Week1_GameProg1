using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int hp;
    public int str;

    public MeshRenderer playerMesh;

    public Color playerColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = str * 100;
        playerMesh.material.color = playerColor;
    }
}
