using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Creates a new menu option to assign a material (texture) to tiles
public class menuScript {
  [MenuItem("Tools/Assign Tile Material")]

  public static void assignTileMaterial() {

    GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
    Material material = Resources.Load<Material>("Tile");

    foreach (GameObject t in tiles) {

      t.GetComponent<Renderer>().material = material;
    }
  }

  [MenuItem("Tools/Assign Tile Script")]
  public static void assignTileScript() {

    GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

    foreach (GameObject t in tiles) {

      t.AddComponent<Tile>();

    }
  }
}
