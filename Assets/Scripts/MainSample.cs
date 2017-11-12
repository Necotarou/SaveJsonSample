using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainSample : MonoBehaviour {


	protected void Start () {

		// セーブ
		Save();


		// ロード
		Load();
	}



	// セーブ
	private void Save()
	{
		// データ格納先
		UserData data = new UserData();

		// サンプルデータ代入
		data.Hp = 100;
		data.Mp = 200;
		data.StringList = new List<string>();
		data.StringList.Add("CS");
		data.StringList.Add("JavaScript");
		data.StringList.Add("Boo");

		// セーブ
		string saveJson = data.Save();
		PlayerPrefs.SetString("Data", saveJson);

		Debug.Log(string.Format("Save {0}", saveJson));
	}


	// ロード
	private void Load()
	{
		// ロード
		string json = PlayerPrefs.GetString("Data", string.Empty);
		UserData userData = UserData.Load(json);

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
