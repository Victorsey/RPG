using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileScript : MonoBehaviour
{
    public Tilemap tilemap;
    public TileBase[] tileHRes = new TileBase[10];
    public TileBase[] tileLRes = new TileBase[10];
    private TileBase tile;
    public Dictionary<TileBase, TileBase> map = new Dictionary<TileBase, TileBase>();
    public int arena;
    private Vector3Int v3;
    private bool zoom = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
        tilemap = GetComponent<Tilemap>();
        for(int i=0; i<tileLRes.Length; i++)
        {
            Debug.Log(i);
            map.Add(tileLRes[i], tileHRes[i]);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !zoom)
        {
            ZoomIn(player.transform.position);
        }
        
        
        
    }
    
    void ZoomIn(Vector3 center)
    {
        center = tilemap.WorldToCell(center);
        for(int i=0; i<arena; i++)
        {
            for(int j=0; j<arena; j++)
            {
                if (i < (arena - 1) / 2)
                {
                    if(j < (arena - 1) / 2)
                    {
                        v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3) && i+j-((arena-1)/2)>=0)
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }

                    }
                    if(j> (arena - 1) / 2 )
                    {
                        v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3) && -i+j-((arena-1)/2)<=0)
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }
                    }
                    if(j == (arena-1)/2 )
                    {
                        v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3))
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }
                    }
                }
                if(i> (arena - 1)/2 )
                {
                    if (j < (arena - 1) / 2)
                    {
                        v3.Set((int)center.x + i - (arena-1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3) && i - j - ((arena - 1) / 2) <= 0)
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }
                    }
                    if(j> (arena - 1)/2)
                    {
                        v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3) && i + j -(arena-1) -(arena-1)/2 <= 0)
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }
                    }
                    if(j== (arena - 1) / 2)
                    {
                        v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                        if (tilemap.HasTile(v3))
                        {
                            map.TryGetValue(tilemap.GetTile(v3), out tile);
                            tilemap.SetTile(v3, tile);
                        }
                    }
                }
                if(i==(arena-1)/2)
                {
                    v3.Set((int)center.x + i - (arena - 1) / 2, (int)center.y + j - (arena - 1) / 2, 0);
                    if (tilemap.HasTile(v3))
                    {
                        map.TryGetValue(tilemap.GetTile(v3), out tile);
                        tilemap.SetTile(v3, tile);
                    }
                }
            }
        }
        //tilemap.RefreshAllTiles();
    }
}
