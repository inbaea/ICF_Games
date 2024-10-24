using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float deg;
    public float turrentSpeed;
    public GameObject turret;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            deg = deg + Time.deltaTime * turrentSpeed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad)+200, Mathf.Sin(rad)+200);
            turret.transform.eulerAngles = new Vector3(0,0,deg);
        }else if(Input.GetKey(KeyCode.DownArrow)){

            deg = deg - Time.deltaTime * turrentSpeed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad)+200, Mathf.Sin(rad)+200);
            turret.transform.eulerAngles = new Vector3(0,0,deg);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject go = Instantiate(bullet);
            go.transform.position = turret.transform.position;
        }
    }
}
