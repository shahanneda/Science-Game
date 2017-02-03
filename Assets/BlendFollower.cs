using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
namespace Main{


	public class BlendFollower : MonoBehaviour
	{
		public Transform leader;
		public float followSharpness = 2f;
		private Vector3 OffSetVector;
		public float yOffSet;
		public float xOffset;

		void LateUpdate()
		{
			OffSetVector = new Vector3(leader.position.x - xOffset, leader.position.y - yOffSet , leader.position.z);
			transform.position += (OffSetVector - transform.position) * followSharpness;
		}
	}
}