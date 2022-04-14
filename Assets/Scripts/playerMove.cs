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
  void Update() {

    if(moving) {

      FinsSelectableTiles();
    }

    else {

      //insert move function
    }

  }

  void CheckMouse() {
    
    if(Input.GetMouseButtonUp(0)) {

      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

      RaycastHit hit;

      if(Physics.Raycast(ray, out hit)) {

        if(hit.collider.tag == "Tile") {

          Tile t = hit.collider.GetComponent<Tile>();

          if(t.selectable) {

            t.target = true;
            moving = false;
          }
        }
      }
    }
  }
}
