using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    GameObject x, y, z, x_, y_, z_, block, text;
    GraphicRaycaster gr;
    PointerEventData ped;
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
        gr = GameObject.FindGameObjectWithTag("Finish").GetComponent<GraphicRaycaster>();
        ped = new PointerEventData(null);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            int a;
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
                a = 1;
            else
                a = -1;
            ped.position = Input.mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(ped, results);
            for(int i = results.Count - 1; i >= 0; i--)
            {
                if (results[i].gameObject.tag.Equals("x"))
                {
                    x.GetComponent<InputField>().text = (int.Parse(x.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
                else if (results[i].gameObject.tag.Equals("y"))
                {
                    y.GetComponent<InputField>().text = (int.Parse(y.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
                else if (results[i].gameObject.tag.Equals("z"))
                {
                    z.GetComponent<InputField>().text = (int.Parse(z.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
                else if (results[i].gameObject.tag.Equals("x_"))
                {
                    x_.GetComponent<InputField>().text = (int.Parse(x_.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
                else if (results[i].gameObject.tag.Equals("y_"))
                {
                    y_.GetComponent<InputField>().text = (int.Parse(y_.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
                else if (results[i].gameObject.tag.Equals("z_"))
                {
                    z_.GetComponent<InputField>().text = (int.Parse(z_.GetComponent<InputField>().text) + a).ToString();
                    break;
                }
            }
        }
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