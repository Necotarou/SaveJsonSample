using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class UserData {

	// 保存データ
	public int Hp;
	public int Mp;

	public List<string> StringList;



	// データセーブ
	public string Save()
	{
		string json = JsonUtility.ToJson(this);

		return json;
	}

	// データロード
	public static UserData Load(string json)
	{
		UserData userData = JsonUtility.FromJson<UserData>(json);

		return userData;
	}

}
