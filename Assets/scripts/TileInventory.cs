using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInventory : MonoBehaviour
{
    // Start is called before the first frame update
    private bool[] tiles;
    //private int size;
    void Start()
    {
        tiles = new bool[7];
        for(int i = 0; i < 7; i++) {
            tiles[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void findTile(GameObject tile) {
        if(tile.name == "tile1") {
            tiles[0] = true;
        }
        else if(tile.name == "tile2") {
            tiles[1] = true;
        }
        else if(tile.name == "tile3") {
            tiles[2] = true;
        }
        else if(tile.name == "tile4") {
            tiles[3] = true;
        }
        else if(tile.name == "tile5") {
            tiles[4] = true;
        }
        else if(tile.name == "tile6") {
            tiles[5] = true;
        }
        else if(tile.name == "tile7") {
            tiles[6] = true;
        }
        else {

        }
    }

    bool[] loadTile() {
        return tiles;
    }
}
