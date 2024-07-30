using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D body;
    [SerializeField] Sprite[] bombs;
    public int ind;
    void Start()
    {
        ind = Random.Range(0, bombs.Length);
        body = GetComponent<Rigidbody2D>();
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if(bombs.Length>0) renderer.sprite = bombs[ind];
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(0,-2f);
        if(transform.position.y<-10f)
        {
            Destroy(gameObject);
        }
    }
}
