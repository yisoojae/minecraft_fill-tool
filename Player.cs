using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    GameObject x, y, z, x_, y_, z_, block, text;
    // Start is called before the first frame update
    void Start()
    {
        x = GameObject.FindGameObjectWithTag("x");
        y = GameObject.FindGameObjectWithTag("y");
        z = GameObject.FindGameObjectWithTag("z");
        x_ = GameObject.FindGameObjectWithTag("x_");
        y_ = GameObject.FindGameObjectWithTag("y_");
        z_ = GameObject.FindGameObjectWithTag("z_");
        block = GameObject.FindGameObjectWithTag("block");
        text = GameObject.FindGameObjectWithTag("text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void print()
    {
        
    }
    public void copy()
    {
        
    }
    public void delete()
    {

    }    
}
