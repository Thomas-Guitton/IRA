using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attic : MonoBehaviour
{
    public int id;
    public int number = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetNumber(int n)
    {
        number = n;
    }

    public int GetNumber()
    {
        return number;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
