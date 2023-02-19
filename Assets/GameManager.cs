using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Block[] blocks;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        foreach(var i in blocks)
        {
            Destroy(i.gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsClear())
        {
            if (!done)
            {
                Debug.Log("game clear!!");
            }
        }
    }

    // GameClear
    private bool IsClear()
    {
        foreach( var block in blocks)
        {
            if (block != null)
            {
                return false;

            }
        }
        this.done = true;
        return true;
    }

    public void GameOver ()
    {
        Debug.Log("Game Over");

    }

}
