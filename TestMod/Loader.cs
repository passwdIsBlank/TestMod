﻿using UnityEngine;

namespace TestMod
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(TestMod));
			gameObject.AddComponent<TestMod>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}