using UnityEngine;
using Winch.Core;

namespace TestMod
{
	public class TestMod : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(TestMod)} has loaded!");
		}
	}
}
