using UnityEngine;
using System.Collections;

public class ScoreView : MonoBehaviour {
	public Scorer Scorer;
	public GameRuler GameRuler;
	void OnGUI() 
	{
		// GUIの見た目を変える。
		GUIStyle guiStyle = new GUIStyle();
		GUIStyleState styleState = new GUIStyleState();

		// GUI背景色のバックアップ
		Color backColor = GUI.backgroundColor;

		// GUI背景の色を設定
		GUI.backgroundColor = new Color(0.0f, 0.0f, 0.0f, 0.5f);

		// 背景用テクスチャを設定
		styleState.background = Texture2D.whiteTexture;

		// テキストの色を設定
		styleState.textColor = Color.green;

		// スタイルの設定。
		guiStyle.normal = styleState;

		if(GameRuler.isInGame()) {
			GUI.Label(new Rect(130, 0, 65, 20),"Score " + Scorer.GetScore(), guiStyle);
		}
		else if(GameRuler.isGameOver()) {
			GUI.Label(new Rect(0, 0, Screen.width, Screen.height),"GameOver", guiStyle);
		}
		else if(GameRuler.isGoal()) {
			GUI.Label(new Rect(0, 0, Screen.width, Screen.height),"Goal", guiStyle);
			GUI.Label(new Rect(130, 0, 65, 20),"Score " + Scorer.GetScore(), guiStyle);
		}
	}
}
