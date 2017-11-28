using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using System.Linq;

public class GestionaAtlas : MonoBehaviour {
	public int id_sprite;
	public SpriteAtlas m_atlas;
	public SpriteRenderer m_render;
	//private Sprite[] sprite_array;
	private List<Sprite> sprite_list;
	// Use this for initialization
	void Start () {
		Sprite[] sprite_array = new Sprite[m_atlas.spriteCount];

		// recoje el sprite por nombre:
		//m_render.sprite = m_atlas.GetSprite ("1");

		// recoje un array de sprites desde el atlas:
		m_atlas.GetSprites(sprite_array);

		m_render.sprite = sprite_array [5];

		sprite_list = sprite_array.ToList ();


	}
	
	// Update is called once per frame
	void Update () {
		m_render.sprite = sprite_list [id_sprite];
	}
}
