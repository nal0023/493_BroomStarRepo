using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : tacticsMove
{
    // Start is called before the first frame update
    void Start()
    {
      inIt();
    }

    // Update is called once per frame
    void Update()
    {
      FinsSelectableTiles();
    }
}
