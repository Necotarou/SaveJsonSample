using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData {

	// 保存データ
	public int Hp;
	public int Mp;

	public List<string> StringList;



	// データセーブ
	public string Save(UserData data)
	{
		string json = JsonUtility.ToJson(data);

		return json;
	}

	// データロード
	public UserData Load(string json)
	{
		UserData userData = JsonUtility.FromJson<UserData>(json);

		return userData;
	}

}
