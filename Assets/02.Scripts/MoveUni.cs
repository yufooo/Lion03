using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUni : MonoBehaviour
{
    public GameObject[] Planet;
    public int dis = 0;
    // Start is called before the first frame update
    void Start()
    {
        MovePlanet();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Planet.Length; i++)
        {
            switch (Planet[i].name)
            {
                case "[obj]Sun":
                    Planet[i].transform.position = new Vector3(0*dis, 0, 0);
                    break;
                
                case "[obj]Mercury":
                    Planet[i].transform.position = new Vector3(0.39f*dis, 0, 0);
                    break;
                
                case "[obj]Venus":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                case "[obj]Earth":
                    Planet[i].transform.Rotate(new Vector3(Mathf.Sin(23.4f*Mathf.Deg2Rad),Mathf.Cos(23.4f*Mathf.Deg2Rad),0),Space.World);
                    Planet[i].transform.rotation=Quaternion.Euler(Mathf.Sin(23.4f*Mathf.Deg2Rad),Mathf.Cos(23.4f*Mathf.Deg2Rad) , 0);
                    Debug.Log(Mathf.Deg2Rad);
                    break;
                
                case "[obj]Mars":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                case "[obj]Jupiter":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                case "[obj]Saturn":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                case "[obj]Uranus":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                case "[obj]Neptune":
                    Planet[i].transform.position = new Vector3();
                    break;
                
                default:
                    Debug.Log("nothing");
                    break;
                
            }
        }
    }

    void MovePlanet()
    {
        for (int i = 0; i < Planet.Length; i++)
        {
            switch (Planet[i].name)
            {
                case "[obj]Sun":
                    Planet[i].transform.position = new Vector3(0*dis, 0, 0);
                    break;
                
                case "[obj]Mercury":
                    Planet[i].transform.position = new Vector3(0.39f*dis, 0, 0);
                    break;
                
                case "[obj]Venus":
                    Planet[i].transform.position = new Vector3(0.72f*dis, 0, 0);
                    break;
                
                case "[obj]Earth":
                    Planet[i].transform.position = new Vector3(1*dis, 0, 0);
                    break;
                
                case "[obj]Mars":
                    Planet[i].transform.position = new Vector3(1.52f*dis, 0, 0);
                    break;
                
                case "[obj]Jupiter":
                    Planet[i].transform.position = new Vector3(5.20f*dis, 0, 0);
                    break;
                
                case "[obj]Saturn":
                    Planet[i].transform.position = new Vector3(9.58f*dis, 0, 0);
                    break;
                
                case "[obj]Uranus":
                    Planet[i].transform.position = new Vector3(19.20f*dis, 0, 0);
                    break;
                
                case "[obj]Neptune":
                    Planet[i].transform.position = new Vector3(30.05f*dis, 0, 0);
                    break;
                
                default:
                    Debug.Log("nothing");
                    break;
                
            }
        }
            
    }
    
}
