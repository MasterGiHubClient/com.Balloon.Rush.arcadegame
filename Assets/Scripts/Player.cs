using DigitalRuby.SoundManagerNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] AudioSource sound;   
    
    // Start is called before the first frame update
    [SerializeField] Game game;
   // [SerializeField] Sprite[] skins;
    private float pos = 0;
    public float Pos { get { return pos; } set { pos = value;
            pos = Mathf.Min(pos, 2.5f);
            pos = Mathf.Max(pos, -2.5f);
        } }

    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
     //   spriteRenderer.sprite = skins[PlayerPrefs.GetInt("Key", 0)];
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3 (pos, transform.position.y, transform.position.z);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Heart")
        {
            sound.PlayOneShotSoundManaged(sound.clip);
            Heart heart = collision.gameObject.GetComponent<Heart>();
            game.count+=(heart.ind + 1)*3;
            Destroy(collision.gameObject);  
        } else
        {
            game.collision();
            Destroy(collision.gameObject);
        }
    }
}
