using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainSample : MonoBehaviour {

	// データ格納先
	UserData userData = new UserData();

	protected void Start () {

		// セーブ
		Save();


		// ロード
		Load();
	}



	// セーブ
	private void Save()
	{
		// サンプルデータ代入
		userData.Hp = 100;
		userData.Mp = 200;
		userData.StringList = new List<string>();
		userData.StringList.Add("CS");
		userData.StringList.Add("JavaScript");
		userData.StringList.Add("Boo");

		// セーブ
		string saveJson = userData.Save(userData);
		PlayerPrefs.SetString("Data", saveJson);

		Debug.Log(string.Format("Save {0}", saveJson));
	}


	// ロード
	private void Load()
	{
		// ロード
		string json = PlayerPrefs.GetString("Data", string.Empty);
		UserData loadData = userData.Load(json);

		// データ表示
		Debug.Log(string.Format("Hp = {0}", userData.Hp));
		Debug.Log(string.Format("Mp = {0}", userData.Mp));
		foreach (string data in userData.StringList)
		{
			Debug.Log(string.Format("StringList = {0}", data));
		}
	}


	protected void Update () {
		
	}
}
