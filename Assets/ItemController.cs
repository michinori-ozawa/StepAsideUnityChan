using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour
{

		//コインが見える可能性のあるz軸の最大値（課題）
		private float visiblePosZ = -10f;

		//UnityChanのデータを取ってくる（課題）
		private GameObject UnityChan;

        // Use this for initialization
        void Start ()
        {
				//UnityChanのデータを見つけてくる（課題）
				UnityChan = GameObject.Find("unitychan");
			
        }

        // Update is called once per frame
        void Update ()
        {

				Vector3 uPos = UnityChan.transform.position;
				
				Vector3 selfPos = this.transform.position;
				
				//IF文でUNITYちゃんよりマイナスになったら消す
				if( selfPos.z - visiblePosZ < uPos.z)
				{
					Destroy(this.gameObject);
				}
				
        }
}
