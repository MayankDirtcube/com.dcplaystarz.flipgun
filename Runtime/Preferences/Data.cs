/*
* Copyright (c) DeckOfDev
* Email deckofdev@gmail.com
*/

using UnityEngine;

public class Data : MonoBehaviour {

	public static FTG_Data properties;
    public static GameObject[] layers;
	public static GameObject highscoreLine;
	public static GameObject[] gunsGame, gunsMenu;
	public static GameObject scoreLines;

	
	public static GameObject firstBullet, secondBullet, thirdBullet, bulletShell;
	public static GameObject laser, rocket;

	[SerializeField]
	private AssetData[] assetDataList;

	[SerializeField]
	private GameObject[] bulletList;

	[SerializeField]
	private GameObject HighScore;

	[SerializeField]
	private GameObject score;

	void Awake () 
	{
        layers = assetDataList[0].assetList;
		gunsGame = assetDataList[1].assetList;
		gunsMenu = assetDataList[2].assetList;

		firstBullet = bulletList[0];
		secondBullet = bulletList[1];
		thirdBullet = bulletList[2];
		laser = bulletList[3];
		rocket = bulletList[4];
		bulletShell = bulletList[5];

		highscoreLine = HighScore;
		scoreLines = score;

		//Old Code
		//--------------------------------------------------------------------------
		properties = Resources.Load<FTG_Data>("Data/Data");
		//gunsGame = Resources.LoadAll<GameObject>("Prefabs/Guns/Game");
		//gunsMenu = Resources.LoadAll<GameObject>("Prefabs/Guns/Menu");
		//layers = Resources.LoadAll<GameObject>("Prefabs/Layers");
		//highscoreLine = Resources.Load<GameObject>("Prefabs/UI/HighscoreLine");
		//scoreLines = Resources.Load<GameObject>("Prefabs/UI/ScoreLines");
		//firstBullet = Resources.Load<GameObject>("Prefabs/Bullets/BulletFly (1)");	
		//secondBullet = Resources.Load<GameObject>("Prefabs/Bullets/BulletFly (2)");	
		//thirdBullet = Resources.Load<GameObject>("Prefabs/Bullets/BulletFly (3)");
		//laser = Resources.Load<GameObject>("Prefabs/Bullets/BulletFly (4)");
		//rocket = Resources.Load<GameObject>("Prefabs/Bullets/BulletFly (5)");
		//bulletShell = Resources.Load<GameObject>("Prefabs/Bullets/Bullet Shell");	
		//----------------------------------------------------------------------------
	}
}
