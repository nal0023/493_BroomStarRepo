using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public bool walkable = true;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacenyList = new List<Tile>();

    //BFS
    public bool visited = false;
    public Tile parent = null;
    public int distance = 0;

    // Start is called before the first frame update (initialization)
    void Start() {


    }
    // Update is called once per frame
    void Update() {

      if (current) {
        GetComponent<Renderer>().material.color = Color.magenta;
      }
      else if (target) {
          GetComponent<Renderer>().material.color = Color.green;
      }
      else if (selectable) {
          GetComponent<Renderer>().material.color = Color.red;
      }
      else {
          GetComponent<Renderer>().material.color = Color.white;
      }
    }

    public void Reset() {

      current = false;
      target = false;
      selectable = false;

      visited = false;
      parent = null;
      distance = 0;

    }

    public void findNeighbours(float jumpHeight) {

      Reset();

      CheckTile(Vector3.forward, jumpHeight);
      CheckTile(-Vector3.forward, jumpHeight);
      CheckTile(Vector3.right, jumpHeight);
      CheckTile(-Vector3.right, jumpHeight);

    }

    public void CheckTile(Vector3 direction, float jumpHeight) {

      Vector3 halfExtents = new Vector3(0.25f, (1+ jumpHeight) / 2.0f, 0.25f);

      Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtents);

      foreach(Collider item in colliders) {

        Tile tile = item.GetComponent<Tile>();
        if (tile != null && tile.walkable) {

          RaycastHit hit;

          if(Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1)) {

            adjacenyList.Add(tile);
          }

        }
      }
    }
}
